using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class Program
    {
        public static int BinarySearch(int[] array, int target)
        {
            int l = 0, m = 0;
            int r = array.Length - 1;
            while(l <= r)
            {
                m = (l + r) / 2;
                if (array[m] == target) return m;

                if (array[m] > target) r = m - 1;
                else l = m + 1;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            var array = new int[] { 0, 1, 21, 33, 45, 45, 61, 71, 72, 73 };
            var target = 70;
            var output = BinarySearch(array, target);           
        }


    }
}
