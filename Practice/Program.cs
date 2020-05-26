using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        public static int LongestPeak(int[] array)
        {
            int curr_len = 0;
            bool is_peak = false;
            int return_len = 0;

            for(int i = 1; i < array.Length - 1; i++)
            {
                if(is_peak)
                {
                    if (array[i] > array[i + 1])
                    {
                        curr_len++;
                        if (curr_len > return_len) return_len = curr_len;
                    }
                    else
                    {
                        is_peak = false;
                        if (curr_len > return_len) return_len = curr_len;                       
                    }
                }
                else
                {
                    if (array[i] > array[i - 1] && array[i] > array[i + 1])
                    {
                        curr_len = 3;
                        is_peak = true;
                        for (int j = i - 1; j >= 1; j--)
                        {
                            if (array[j] > array[j - 1]) curr_len++;
                            else break;
                        }
                        if (curr_len > return_len) return_len = curr_len;

                    }
                }
                
            }
            return return_len;
        }


        static void Main(string[] args)
        {
            int[] array = new int[] {1,
    1,
    1,
    2,
    3,
    10,
    12,
    -3,
    -3,
    2,
    3,
    45,
    800,
    99,
    98,
    0,
    -1,
    -1,
    2,
    3,
    4,
    5,
    0,
    -1,
    -1};         

            var output = LongestPeak(array);

        }



    }
}
