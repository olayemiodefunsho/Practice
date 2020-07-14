using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class Program
    {
        public static int[] InsertionSort(int[] array)
        {
            int j = 0;
            int holder = 0;

           for(int i = 0; i < array.Length; i++)
           {
                j = i;
                while(j > 0)
                {
                    if (array[j] < array[j - 1])
                    {
                        holder = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = holder;
                        j--;
                    }
                    else break;
                }
           }
            return array;
        }

        static void Main(string[] args)
        {
            var array = new int[] { 3, 2, 5, 5, 6, 8, 9 };
            var output = InsertionSort(array);           
        }


    }
}
