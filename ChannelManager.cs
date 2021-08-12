using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Timers;

namespace Application_Library
{
    //1. Track a list of all client connections
    //2. Grouming (housekeeping) of channels
    //3. Connection limiting
    public class ChannelManager
    {
        readonly ConcurrentDictionary<Guid, IChannel> _channels = new ConcurrentDictionary<Guid, IChannel>();
        readonly Func<IChannel> _channelFactory;
        
        const int GROOMING_INTERVAL_MINUTES = 2;

       private readonly Timer _groomer = new Timer(GROOMING_INTERVAL_MINUTES * 60 * 1000);

        public ChannelManager(Func<IChannel> channelFactory)
        { 
             _channelFactory = channelFactory;

            _groomer.Elapsed += OnGroomerElapsedEventHandler;
            _groomer.Start();
        }

        private void OnGroomerElapsedEventHandler(object sender, ElapsedEventArgs e)
        {
            _groomer.Stop();
            Console.WriteLine($"({DateTime.Now})>> BEGIN SOCKET GROOMING");
            int socketsGroomed = 0;
            try
            {
                var deadChannels = new List<Guid>();


                var delta = DateTime.UtcNow.Subtract(new TimeSpan(0, GROOMING_INTERVAL_MINUTES, 0));

                foreach (var k in _channels.Keys)
                {
                    //get the channel and look at last sent/received to see if channel is alive
                    var c = _channels[k];
                    var mostRecent = DateTime.Compare(c.LastReceived, c.LastSent) > 0 ? c.LastReceived : c.LastSent;
                    if (DateTime.Compare(delta, mostRecent) > 0)
                        deadChannels.Add(k);
                }

                //remove all dead channels
                foreach (var k in deadChannels)
                {
                    Console.WriteLine($"({DateTime.Now})>> Closing/Removing Dead Channel {k}");
                    var c = _channels[k];
                    c.Dispose();
                    socketsGroomed++;
                    _channels.TryRemove(k, out _);
                }

            }
            finally
            {
                _groomer.Start();
            }

            Console.WriteLine($"({ DateTime.Now})>> END SOCKET GROOMING : {socketsGroomed} Sockets Groomed");
        }

        public void Accept(Socket socket)
        {
            var channel = _channelFactory();

            _channels.TryAdd(channel.Id, channel);
            channel.Closed += (s, e) => _channels.TryRemove(channel.Id, out var _);
            channel.Attach(socket); //
        }

        
    }
}
