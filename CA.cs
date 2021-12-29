using System;
using System.Collections.Generic;
using System.Text;

namespace ConcatArray
{
    public static class CA
    {
        public static void ConcatArray(string[] nums, string target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        Console.WriteLine($"{(i, j)}: \"{nums[i]}\" + \"{nums[j]}\"");
                    }
                }
            }
        }
    }
}
