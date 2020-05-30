using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        public static int[] SubarraySort(int[] array)
        {
            var unsorted_list = new List<int>();
            bool not_last = false;
            

            for(int i = 1; i < array.Length - 1; i++)
            {
                if(!(array[i] >= array[i - 1] && array[i] <= array[i+1]))
                {
                    unsorted_list.Add(i);
                }
            }

            if (array[array.Length - 1] < array[array.Length - 2]) unsorted_list.Add(array.Length - 1);

            if (unsorted_list.Count == 0) return new int[] { -1,-1};

            int s_index = unsorted_list[0];
            int l_index = unsorted_list[0];

            foreach (var item in unsorted_list)
            {
                if(array[item] > array[l_index])
                {
                    l_index = item;
                }

                if (array[item] < array[s_index])
                {
                    s_index = item;
                }
            }

            for(int i = 0; i < array.Length; i++)
            {
                if(array[s_index] < array[i])
                {
                    s_index = i;
                    break;
                }
            }

            for(int i = s_index + 1; i < array.Length; i++)
            {

                if (array[l_index] < array[i])
                {
                    l_index = i - 1;
                    not_last = true;
                    break;
                }
            }

            if (!not_last) l_index = array.Length - 1;


            return new int[] { s_index, l_index };
        }


        static void Main(string[] args)
        {
            int[] array = new int[] { 1,2 };

            var output = SubarraySort(array);

        }



    }
}
