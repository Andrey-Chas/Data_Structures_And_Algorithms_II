using System;
using System.Collections.Generic;

namespace Dictionary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> fileNames = new Dictionary<string, string>()
            {
                {".txt", "Text File" },
                {".pdf", "Adobe Reader" },
                {".exe", "Application" },
                {".dox", "Microsoft Word" }
            };

            while (true)
            {
                Console.Write("Please write a file name or type exit to exit the program: ");
                string input = Console.ReadLine().ToLower().Trim();
                if (input == "exit")
                {
                    break;
                }
                string nameOfTheFile = GetData(fileNames, input);
                Console.WriteLine();
                Console.WriteLine($"{nameOfTheFile}");
            }
        }

        private static string GetData(Dictionary<string, string> fileNames, string input)
        {
            int dotPosition = input.LastIndexOf(".");
            if (dotPosition == -1)
            {
                return "There is no such file name";
            }
            string dataToFind = input.Substring(dotPosition);

            if (fileNames.ContainsKey(dataToFind))
            {
                return fileNames[dataToFind];
            }
            else
            {
                return "There is no such file name";
            }
        }
    }
}
