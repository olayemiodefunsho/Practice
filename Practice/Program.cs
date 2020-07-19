using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class Program
    {
        public static int[] SearchForRange(int[] array, int target)
        {
            int l = 0, r = array.Length - 1;
            int l_index = -1, r_index = -1;
            while(l <= r)
            {
                int m = (l + r) / 2;
                if(array[m] == target)
                {
                    if ((m == 0) || (array[m - 1] < array[m]))
                    {
                        l_index = m;
                        break;
                    }

                    if(array[m - 1] == target)
                    {
                        r = m - 1;
                        continue;
                    }
                }

                if(array[m] < target)
                {
                    l = m + 1;
                    continue;
                }

                if(array[m] > target) r = m - 1;                            
            }

            l = 0; r = array.Length - 1;
            while (l <= r)
            {
                int m = (l + r) / 2;
                if (array[m] == target)
                {
                    if ((m == array.Length -1) || (array[m] < array[m + 1]))
                    {
                        r_index = m;
                        break;
                    }

                    if (array[m + 1] == target)
                    {
                        l = m + 1;
                        continue;
                    }
                }

                if (array[m] < target)
                {
                    l = m + 1;
                    continue;
                }

                if (array[m] > target) r = m - 1;
            }


            return new int[] { l_index, r_index };
        }

        static void Main(string[] args)
        {
            var array = new int[] { 0, 1, 21, 33, 45, 45, 45, 45, 61, 71, 73 };
            int target = 45;
            var output = SearchForRange(array, target);           
        }
    }
}
