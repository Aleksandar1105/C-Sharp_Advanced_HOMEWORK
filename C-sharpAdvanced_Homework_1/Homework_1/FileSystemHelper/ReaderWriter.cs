using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.FileSystemHelper
{
    public static class ReaderWriter
    {
        public static string ReadFile(string filePath)
        {
            string result = string.Empty;
            if (!File.Exists(filePath))
            {
                return "File not exist!";
            }
            using (StreamReader sr = new StreamReader(filePath))
            {
                result = sr.ReadToEnd();
            }
            return result;
        }

        public static void WriteFile(string filePath, string data)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(data);
            }
            Console.WriteLine("Succesfully written in a file!");
        }
    }
}