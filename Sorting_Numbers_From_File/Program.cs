using System;
using System.Collections.Generic;
using System.IO;

namespace Sorting_Numbers_From_File
{
    class Program
    {
        static String sourceFile = "C:\\Users\\диан\\source\\repos\\Data_Structures_And_Algorithms_II\\Sorting_Numbers_From_File\\nums.txt";
        static String sortedFile = "C:\\Users\\диан\\source\\repos\\Data_Structures_And_Algorithms_II\\Sorting_Numbers_From_File\\numbers_sorted.txt";
        public static int limit = 3999;
        static List<FileSegment> segments = new List<FileSegment>();
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(sourceFile);
            string line = null;
            List<double> memorySegment = new List<double>();
            while (true)
            {
                line = reader.ReadLine();
                if (line == null)
                {
                    if (memorySegment.Count > 0)
                    {
                        segments.Add(new FileSegment(memorySegment));
                    }
                    break;
                }

                if (memorySegment.Count >= limit)
                {
                    segments.Add(new FileSegment(memorySegment));
                    memorySegment = new List<double>();
                }
                memorySegment.Add(double.Parse(line));
            }

            if (segments.Count > 1)
            {
                mergeSorted();
            }
        }

        static void mergeSorted()
        {
            List<double> nextInLine = new List<double>();
            StreamWriter writer = new StreamWriter(sortedFile);
            while (true)
            {
                nextInLine.Clear();
                foreach (FileSegment segment in segments)
                {
                    nextInLine.Add(segment.Peek());
                }

                int maxIndex = 0;
                double max = nextInLine[maxIndex];
                for (int i = 1; i < nextInLine.Count; i++)
                {
                    if (nextInLine[i] > max)
                    {
                        max = nextInLine[i];
                        maxIndex = i;
                    }
                }

                if (max == double.MinValue)
                {
                    writer.Close();
                    return;
                }

                writer.WriteLine(segments[maxIndex].Get());
            }
        }
    }
}
