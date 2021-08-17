using System;
using System.Collections.Generic;
using System.Text;

namespace solution_leetcode
{
    public class ReverseString
    {
        public static void ReverseStrings(char[] s)
        {
            char[] result = new char[s.Length];

            for (int i = s.Length - 1, j = 0; i >= 0 && j < s.Length; i--)
            {
                result[j] = s[i];
                j++;
            }


            for (int i = 0; i < s.Length; i++)
            {

                Console.Write(result[i]);
            }
        }
    }
}
