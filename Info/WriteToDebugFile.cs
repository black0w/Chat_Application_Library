using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Application_Library
{
    public class WriteToDebugFile
    {

        public static void WriteToFile(string msg)
        {
            string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\ServerStorage\Debug";
            Directory.CreateDirectory(filePath);
            if (!File.Exists(filePath + @"\debug.txt"))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(filePath + @"\debug.txt"))
                {
                    sw.WriteLine($"({DateTime.Now})>> {msg}");
                    sw.Close();
                }
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            try
            {
                using (StreamWriter sw = File.AppendText(filePath + @"\debug.txt"))
                {
                    sw.WriteLine($"({DateTime.Now})>> {msg}");
                    sw.Close();
                }
            }
            catch (IOException) { Console.WriteLine($"({DateTime.Now})>> Cannot write to debug.txt , file is used by another procces"); }
        }
    }
}
