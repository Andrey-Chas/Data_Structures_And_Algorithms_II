using System;
using System.Collections.Generic;

namespace Recursive_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>()
            {
                1,
                3,
                21,
                7,
                8,
                10,
                9,
                6
            };

            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            int i = 0;

            var numsReversed = RecursiveReverse(nums, i);

            foreach (var num in numsReversed)
            {
                Console.WriteLine(num);
            }
        }

        private static List<int> RecursiveReverse(List<int> nums, int i)
        {
            int mid = (nums.Count / 2);
            int temp;
            int replace = nums.Count - 1 - i;
            if (i == mid)
            {
                return nums;
            }
            temp = nums[i];
            nums[i] = nums[replace];
            nums[replace] = temp;
            return RecursiveReverse(nums, i + 1);
        }
    }
}
