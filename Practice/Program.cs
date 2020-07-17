using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class Program
    {
        public static int ShiftedBinarySearch(int[] array, int target)
        {
            int l = 0, r = array.Length - 1, m = 0;

            while(l <= r)
            {
                m = (l + r) / 2;
                if (array[m] == target) return m;
                if(array[l] <= array[m])
                {
                    if(target >= array[l] && target <= array[m]) r = m - 1;
                    else l = m + 1;
                }
                else
                {
                    if (target >= array[m] && target <= array[r]) l = m + 1;
                    else r = m - 1;
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            var array = new int[] { 72, 73, 0, 1, 21, 33, 37, 45, 61, 71 };
            int target = 72;
            var output = ShiftedBinarySearch(array, target);           
        }
    }
}
