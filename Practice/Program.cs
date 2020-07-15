using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class Program
    {
        public static int[] SelectionSort(int[] array)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                int k = i;
                for (int j = i; j < array.Length; j++)
                {
                    if(array[j] < array[k])
                    {
                        k = j;
                    }
                }

                int holder = array[i];
                array[i] = array[k];
                array[k] = holder;
            }

            return array;
        }

        static void Main(string[] args)
        {
            var array = new int[] { 5, 6, 3, 2 };
            var output = SelectionSort(array);           
        }


    }
}
