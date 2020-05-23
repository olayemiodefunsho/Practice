using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        public static bool IsMonotonic(int[] array)
        {
            bool is_mono_asc = true;
            bool is_mono_desc = true;


            for(int i = 0; i < array.Length - 1; i++)
            {
                if (!is_mono_asc && !is_mono_desc) break;

                if(array[i] > array[i+1])
                {
                    is_mono_asc = false;
                }

                if (array[i] < array[i + 1])
                {
                    is_mono_desc = false;
                }
            }

            return is_mono_asc || is_mono_desc;
        }


        static void Main(string[] args)
        {
            int[] array = new int[] { -1, -2, -3, -4, -5 };         

            var output = IsMonotonic(array);
            
        }


        
    }
}
