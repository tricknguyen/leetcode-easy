using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solution_leetcode
{
    //ĐỂ LẤY ĐC SỐ RANDOM random.Next();
    //LẤY ĐC SỐ RANDOM TRONG KHOẢNG  0->n random.Next()%n;
    public class ShuffleAnArray
    {
        public int[] temp;
        Random ran = new Random();
        public ShuffleAnArray(int[] nums)
        {
            temp = nums;
        }
        public int[] Reset()
        {
            return temp;
        }
        public int[] Shuffle()
        {
            if (temp.Length <= 1)
            {
                return temp;
            }

            int[] res = new int[this.temp.Length];
            List<int> cop = new List<int>(temp.ToList());

            for (int i = 0; i < this.temp.Length; i++)
            {
                var j = ran.Next() % cop.Count();
                res[i] = cop[j];
                cop.RemoveAt(j);
            }

            return res;
        }
    }

}
