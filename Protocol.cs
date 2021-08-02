using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Application_Library
{
    public abstract class Protocol<TMessageType>
    {
        const int HEADER_SIZE = 4;

        public async Task<TMessageType> ReceiveAsync(NetworkStream networkStream)
        {
            var bodyLength = await ReadHeader(networkStream).ConfigureAwait(false);
            AssertValidMessageLength(bodyLength);
            return await ReadBody(networkStream, bodyLength).ConfigureAwait(false);
        }

        public async Task SendAsync<T>(NetworkStream networkStream, T message)
        {
            var (header, body) = Encode<T>(message);

            var data = new byte[header.Length + body.Length];
            Buffer.BlockCopy(src: header, 0, dst: data, 0, header.Length);
            Buffer.BlockCopy(src: body, 0, dst: data, header.Length, body.Length);
            try {
                await networkStream.WriteAsync(data, 0, data.Length);
            }
            catch (NullReferenceException)
            {
                throw new Exception("No connection to server");
            }
            }

        async Task<int> ReadHeader(NetworkStream networkStream)
        {
            var headerBytes = await ReadAsync(networkStream, HEADER_SIZE).ConfigureAwait(false);
            return IPAddress.NetworkToHostOrder(BitConverter.ToInt32(headerBytes, 0)); // the bits recieved are in network order, so we need to change them into the right order
        }

        async Task<TMessageType> ReadBody(NetworkStream networkStream, int bodyLength)
        {

            var bodyBytes = await ReadAsync(networkStream, bodyLength).ConfigureAwait(false);
            return Decode(bodyBytes);
        }

        async Task<byte[]> ReadAsync(NetworkStream networkStream, int bytesToRead)
        {

            var buffer = new byte[bytesToRead];
            var bytesRead = 0;
            while (bytesRead < bytesToRead)
            {

                var bytesReceived = await networkStream.ReadAsync(buffer, bytesRead, (bytesToRead - bytesRead)).ConfigureAwait(false);
                if (bytesReceived == 0)
                    throw new Exception($"({DateTime.Now})>> Socket Closed");
                bytesRead += bytesReceived;
            }
            return buffer;



        }

        protected (byte[] header, byte[] bodY) Encode<T>(T message)
        {
            var bodyBytes = EncodeBody<T>(message);
            var headerBytes = BitConverter.GetBytes(IPAddress.HostToNetworkOrder(bodyBytes.Length));

            return (headerBytes, bodyBytes);
        }

        protected abstract TMessageType Decode(byte[] message);

        protected abstract byte[] EncodeBody<T>(T message);

        protected virtual void AssertValidMessageLength(int messageLength)
        {
            if (messageLength < 1)
                Console.WriteLine($"({DateTime.Now})>> Connection closed");
            // throw new ArgumentOutOfRangeException("Invalid message length");
        }
    }
}
