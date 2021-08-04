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
            string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\ServerLogging\Log";
            Directory.CreateDirectory(filePath);

            //Проверяване на файла дали съществува в дадената директория
            if (!File.Exists(filePath + @"\debug.txt"))
            {
                // Създаване на файл
                using (StreamWriter sw = File.CreateText(filePath + @"\Log.txt"))
                {
                    sw.WriteLine($"({DateTime.Now})>> {msg}");
                }
                return;
            }

            // Текстът се добавя в края на файла
            // Файлът ще става с по-големи размери
            // с всяко добавяне на текст, освен
            // ако не се прочиства на определено време.
            try
            {
                using (StreamWriter sw = File.AppendText(filePath + @"\Log.txt"))
                {
                    sw.WriteLine($"({DateTime.Now})>> {msg}");
                }
            }
            catch (IOException)
            {
                Console.WriteLine($"({DateTime.Now})>> Cannot write to debug.txt , file is used by another procces");
            }
        }
    }
}
