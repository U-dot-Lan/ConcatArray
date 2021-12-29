using System;

namespace ConcatArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = new string[] { "777", "7", "77", "77" };
            string target = "7777";
            CA.ConcatArray(nums, target);
            string[] nums1 = new string[] { "123", "4", "12", "34" };
            string target1 = "1234";
            CA.ConcatArray(nums1, target1);

        }
    }
}
