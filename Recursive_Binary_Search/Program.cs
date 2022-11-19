using System;
using System.Collections.Generic;

namespace Recursive_Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>()
            {
                1,
                5,
                7,
                3,
                9,
                12,
                4,
                73
            };

            int index_found = RecursiveBinarySearch(nums, 0, nums.Count, 8, 10);

            if (index_found == -1)
            {
                Console.WriteLine("Element is not present");
            }
            else
            {
                Console.WriteLine($"Element is present at index {index_found}");
            }
        }

        public static int RecursiveBinarySearch(List<int> nums, int lo_p, int hi_p, int a, int b)
        {
            nums.Sort();
            int find_index = (a + b) / 2;

            if (hi_p >= lo_p)
            {
                int mid = lo_p + (hi_p - lo_p) / 2;

                if (nums[mid] == find_index)
                {
                    return mid;
                }

                if (nums[mid] > find_index)
                {
                    return RecursiveBinarySearch(nums, lo_p, mid - 1, a, b);
                }

                return RecursiveBinarySearch(nums, mid + 1, hi_p, a, b);
            }
            return -1;
        }
    }
}
