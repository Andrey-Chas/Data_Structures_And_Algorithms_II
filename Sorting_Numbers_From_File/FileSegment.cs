using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sorting_Numbers_From_File
{
    class FileSegment
    {
        static int nr = 0;
        string fileName = null;
        StreamReader reader;
        double nextInLine;
        public FileSegment(List<double> numbers)
        {
            numbers.Sort();
            numbers.Reverse();
            fileName = "C:\\Users\\диан\\source\\repos\\Data_Structures_And_Algorithms_II\\Sorting_Numbers_From_File\\" + (++nr) + ".txt";
            List<string> stringLines = new List<string>();
            foreach (double n in numbers)
            {
                stringLines.Add(n.ToString());
            }
            File.WriteAllLines(fileName, stringLines);
            reader = new StreamReader(fileName);
            nextInLine = double.Parse(reader.ReadLine());
        }

        public double Peek()
        {
            return nextInLine;
        }

        public double Get()
        {
            if (nextInLine == double.MinValue)
            {
                return nextInLine;
            }

            double result = nextInLine;
            string line = reader.ReadLine();
            if ((line == null) || line.Trim().Equals(""))
            {
                nextInLine = double.MinValue;
            }
            else
            {
                nextInLine = double.Parse(line);
            }
            return result;
        }
    }
}
