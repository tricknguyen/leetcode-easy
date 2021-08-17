using System;
using System.Collections.Generic;
using System.Text;

namespace solution_leetcode
{
    public class ClimbingStairs
    {
        public static int ClimbStairs(int n)
        {
            if (n == 1 || n == 2)
                return n;
            int first = 1, second = 2, count = 0;

            for (int i = 3; i <= n; i++)
            {
                count = first + second;
                first = second;
                second = count;
            }
            return count;
        }
    }
}
