 using System;
using System.Collections.Generic;

namespace _2sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            int target =11;
            int[] result = TwoSum(nums, target);
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
        static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    return new int[] { dict[nums[i]], i };
                }
                else
                {
                    if (!dict.ContainsKey(target - nums[i]))
                        dict.Add(target - nums[i], i);
                }
            }
            return new int[] { -1, -1 };
        }

    }
}
