using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Data_Structures_And_Algorithms_II
{
    public class Programming_Practice
    {
        static void Main(string[] args)
        {
            //double a = 183837474.08837000002;
            //double b = 7373.0000056;
            //double x1 = a / b * Math.PI;
            //double x2 = a * Math.PI / b;

            //if (x1 == x2)
            //{
            //    Console.WriteLine("equal");
            //}
            //else
            //{
            //    Console.WriteLine("not equal");
            //}

            //if (Math.Abs(x1 - x2) < 0.0001)
            //{
            //    Console.WriteLine("almost equal");
            //}

            //Console.ReadLine();

            // ToUpperRemoveSpaces();

            int leng = 38;

            // CutAString(leng);

            // DeleteNegativeNumbers();

            // DeleteNegativeNumbersOneMoreWay();

            // SortByTheLengthOfTheElements();

            List<string> a = new List<string>()
            {
                "hello",
                "arm",
                "link",
                "programming",
                "group",
                "sort",
                "array",
                "list"
            };

            List<string> b = new List<string>()
            {
                "hello",
                "good",
                "link",
                "programming",
                "function",
                "cool",
                "array",
                "string"
            };

            List<string> output = FindSameElements(a, b);

            // PrintElements(output);

            string file = @"C:\Users\диан\source\repos\Data_Structures_And_Algorithms_II\Data_Structures_And_Algorithms_II\nums0.txt";

            List<int> nums = new List<int>()
            {
                5,
                6,
                10,
                128,
                85,
                27,
                39,
                150,
                127,
                8
            };

            // BinarySearch(file, 39, 41);

            // BinarySearch(file, 128, 150);

            // BinarySearch(file, 0, 4999);

            int lo_p = 0;
            int list_leng = nums.Count;
            int find_index = 50;

            // int index_found = AnotherBinarySearch(nums, lo_p, list_leng - 1, find_index);

            find_index = 128;

            // index_found = AnotherBinarySearch(nums, lo_p, list_leng - 1, find_index);

            find_index = 5;

            // index_found = AnotherBinarySearch(nums, lo_p, list_leng - 1, find_index);

            // if (index_found == -1)
            // {
            //     Console.WriteLine("Element is not present");
            // }
            // else
            // {
            //     Console.WriteLine($"Element is at index {index_found}");
            // }

            // string file = @"C:\Users\диан\source\repos\Data_Structures_And_Algorithms_II\Data_Structures_And_Algorithms_II\nums.txt";

            // SortNumsFromFile(file);

            string input = "({[}])";

            Stack<char> inputS = StackInput(input);

            AreBracketsCorrect(inputS, input);

            // Console.WriteLine("Unsorted list of names:");
            // List<string> names = new List<string>()
            // {
            //     "Vesso",
            //     "Ian",
            //     "Miro",
            //     "Ardita",
            //     "Sally",
            //     "Bill",
            //     "Li",
            //     "John"
            // };
            // Display(names);

            // Console.WriteLine();
            // Console.WriteLine("Sorted names by length:");
            // names.Sort(CompareByTheLength);
            // Display(names);
        }

        public static void ToUpperRemoveSpaces()
        {
            string s = "this is a    chapter   title";
            string[] sAsArr = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder resultS = new StringBuilder();
            foreach (var sen in sAsArr)
            {
                resultS.Append(Char.ToUpper(sen[0]) + sen.Substring(1) + " ");
            }

            Console.WriteLine(resultS.ToString().Trim());
        }

        public static void CutAString(int leng)
        {
            string some_text = "There is a bug (with 8 legs) in the database table.";
            string some_text_cut = some_text.Substring(0, leng);
            string dots = "...";
            if (some_text_cut.IndexOf(' ') != -1)
            {
                if (some_text[leng] == ' ')
                {
                    Console.WriteLine($"{some_text_cut} {dots}");
                }
                else
                {
                    for (int i = leng - 1; i > 0; i--)
                    {
                        if (some_text_cut[i] == ' ')
                        {
                            some_text_cut = some_text_cut.Substring(0, i);
                            break;
                        }
                    }
                    Console.WriteLine($"{some_text_cut} {dots}");
                }
            }
            else
            {
                string[] some_text_as_arr = some_text.Split(' ');
                StringBuilder some_text_cut_sb = new StringBuilder();
                some_text_cut_sb.Append(some_text_as_arr[0]);
                Console.WriteLine($"{some_text_cut_sb} {dots}");
            }
        }

        public static void DeleteNegativeNumbers()
        {
            List<int> nums = new List<int>();
            nums.Add(2);
            nums.Add(3);
            nums.Add(-1);
            nums.Add(-2);
            nums.Add(10);
            nums.Add(44);
            List<int> numsWithoutNegative = new List<int>();

            foreach (var num in nums)
            {
                if (num > 0)
                {
                    numsWithoutNegative.Add(num);
                }
            }

            foreach (var num in numsWithoutNegative)
            {
                Console.WriteLine(num);
            }
        }

        public static void DeleteNegativeNumbersOneMoreWay()
        {
            List<int> nums = new List<int>();
            nums.Add(2);
            nums.Add(3);
            nums.Add(-1);
            nums.Add(-2);
            nums.Add(10);
            nums.Add(44);

            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] < 0)
                {
                    nums.RemoveAt(i);
                    i--;
                }
            }

            foreach (var num in nums)
            {
                Console.WriteLine($"{num}");
            }
        }

        public static void SortByTheLengthOfTheElements()
        {
            List<string> words = new List<string>()
            {
                "hello",
                "arm",
                "link",
                "programming",
                "group",
                "sort",
                "array",
                "list"
            };

            int n = words.Count;
            string temp;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (words[j].Length > words[j + 1].Length)
                    {
                        temp = words[j];
                        words[j] = words[j + 1];
                        words[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                {
                    break;
                }
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }

        public static List<string> FindSameElements(List<string> a, List<string> b)
        {
            List<string> aAndB = new List<string>();

            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < b.Count; j++)
                {
                    if (a[i] == b[j])
                    {
                        aAndB.Add(a[i]);
                    }
                }
            }

            return aAndB;
        }

        public static void BinarySearch(string file, int a, int b)
        {
            List<int> nums = new List<int>();
            if (File.Exists(file))
            {
                string[] numsAsStr = File.ReadAllLines(file);
                foreach (var num in numsAsStr)
                {
                    nums.Add(Convert.ToInt32(num));
                }
            }

            Console.WriteLine();

            int low = 0;
            int high = nums.Count - 1;
            int mid;
            int find_index;

            if (b > a)
            {
                find_index = ((b - a) / 2) + a;
            }
            else
            {
                find_index = ((a - b) / 2) + b;
            }

            while (high - low > 1)
            {
                mid = (high + low) / 2;

                if (nums[mid] < find_index)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }

            if (nums[low] == find_index)
            {
                Console.WriteLine($"Element is at index {low}");
            }
            else if (nums[high] == find_index)
            {
                Console.WriteLine($"Element is at index {high}");
            }
            else
            {
                Console.WriteLine("Element is not present");
            }
        }

        public static int AnotherBinarySearch(List<int> nums, int lo_p, int hi_p, int find_index)
        {
            nums.Sort();

            if (hi_p >= lo_p)
            {
                int mid = lo_p + (hi_p - lo_p) / 2;

                if (nums[mid] == find_index)
                {
                    Console.WriteLine($"Element is at index {mid}");
                }

                if (nums[mid] > find_index)
                {
                    return AnotherBinarySearch(nums, lo_p, mid - 1, find_index);
                }

                return AnotherBinarySearch(nums, mid + 1, hi_p, find_index);
            }

            return -1;
        }

        public static void SortNumsFromFile(string file)
        {
            if (File.Exists(file))
            {
                string[] numsAsStr = File.ReadAllLines(file);

                int count = 0;

                string pathToWrite = @"C:\Users\диан\source\repos\Data_Structures_And_Algorithms_II\Data_Structures_And_Algorithms_II\";

                List<double> nums = new List<double>();
                List<string> numsAsStrArr = new List<string>();

                foreach (var num in numsAsStr)
                {
                    nums.Add(Convert.ToDouble(num));

                    if (nums.Count == 2000)
                    {
                        nums.Sort();
                        foreach (var num1 in nums)
                        {
                            numsAsStrArr.Add(Convert.ToString(num1));
                        }
                        File.WriteAllLines(pathToWrite + "nums" + count + ".txt", numsAsStrArr);
                        count++;
                        nums.Clear();
                        numsAsStrArr.Clear();
                    }
                }

                nums.Sort();
                foreach (var num in nums)
                {

                    numsAsStrArr.Add(Convert.ToString(num));
                }
                File.WriteAllLines(pathToWrite + "nums" + count + ".txt", numsAsStrArr);

                List<double> findMin = new List<double>();
                string sortedPath = @"C:\Users\диан\source\repos\Data_Structures_And_Algorithms_II\Data_Structures_And_Algorithms_II\sorted.txt";
                string readPath = @"C:\Users\диан\source\repos\Data_Structures_And_Algorithms_II\Data_Structures_And_Algorithms_II\";
                int index = 0;

                for (int i = 0; i < numsAsStr.Length; i++)
                {
                    if (findMin.Count == count + 1)
                    {
                        index = findMin.IndexOf(findMin.Min());
                        File.WriteAllText(sortedPath, Convert.ToString(findMin.Min()));
                        findMin.RemoveAt(index);
                    }

                    if (findMin.Count != count + 1)
                    {
                        string elementToAdd = File.ReadAllLines(readPath + "nums" + index + ".txt").ElementAt(i);
                        findMin.Insert(index, Convert.ToDouble(elementToAdd));
                    }
                }
            }
        }

        public static void AreBracketsCorrect(Stack<char> input, string userIn)
        {
            int countCB = 0;
            int countOB = 0;
            int countCBS = 0;
            int countOBS = 0;
            int countCBC = 0;
            int countOBC = 0;

            while (input.Count > 0)
            {
                if (input.Pop() == ')')
                {
                    countCB++;
                }
            }

            input = StackInput(userIn);

            while (input.Count > 0)
            {
                if (input.Pop() == ']')
                {
                    countCBS++;
                }
            }

            input = StackInput(userIn);

            while (input.Count > 0)
            {
                if (input.Pop() == '}')
                {
                    countCBC++;
                }
            }

            input = StackInput(userIn);

            while (input.Count > 0)
            {
                if (input.Pop() == '(')
                {
                    countOB++;
                }
            }

            input = StackInput(userIn);

            while (input.Count > 0)
            {
                if (input.Pop() == '[')
                {
                    countOBS++;
                }
            }

            input = StackInput(userIn);

            while (input.Count > 0)
            {
                if (input.Pop() == '{')
                {
                    countOBC++;
                }
            }

            if (countCB == countOB && countCBS == countOBS && countCBC == countOBC)
            {
                Console.WriteLine($"In the input {userIn} brackets are correct");
            }
            else
            {
                Console.WriteLine($"In the expression {userIn} brackets are incorrect");
            }
        }

        public static void AreBracketsCorrect1(string input)
        {
            Stack<char> inputOB = new Stack<char>();

            char[] inputAsCharArr = input.ToCharArray();

            foreach (var item in inputAsCharArr)
            {
                if (item == '(')
                {
                    inputOB.Push(item);
                }
                else if (item == '[')
                {
                    inputOB.Push(item);
                }
                else if (item == '{')
                {
                    inputOB.Push(item);
                }
            }

            for (int i = 0; i < inputAsCharArr.Length; i++)
            {

            }
        }

        public static Stack<char> StackInput(string input)
        {
            Stack<char> inputS = new Stack<char>();

            char[] inputAsArr = input.ToCharArray();

            foreach (var character in inputAsArr)
            {
                inputS.Push(character);
            }

            return inputS;
        }


        public static void PrintElements(List<string> output)
        {
            foreach (var element in output)
            {
                Console.WriteLine(element);
            }
        }


        private static int CompareByTheLength(string x, string y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (y == null)
                {
                    return 1;
                }
                else
                {
                    int retval = x.Length.CompareTo(y.Length);

                    if (retval != 0)
                    {
                        return retval;
                    }
                    else
                    {
                        return x.CompareTo(y);
                    }
                }
            }
        }


        public static void Display(List<string> names)
        {
            Console.WriteLine();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
