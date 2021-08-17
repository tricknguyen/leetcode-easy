using System;
using System.Collections.Generic;
using System.Text;

namespace solution_leetcode
{
    public class MergeSortedArray
    {
        public static void MergeSortArray(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }
            Array.Sort(nums1);

            for (int i = 0; i < m + n; i++)
            {
                Console.Write(nums1[i] + " ");
            }
        }

    }
}
