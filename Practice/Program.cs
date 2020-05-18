using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            int[] return_array = new int[2];
            Array.Sort(array);

            int x = 0;
            int y = array.Length - 1;

            while (x < y)
            {
                if (array[x] + array[y] == targetSum)
                {
                    return new int[] { array[x], array[y] };                   
                }

                if (array[x] + array[y] < targetSum)
                {
                    x++;
                    continue;
                }

                if (array[x] + array[y] > targetSum)
                {
                    y--;
                    continue;
                }
            }


            return new int[0];
        }


        static void Main(string[] args)
        {
            int[] array = new int[] {-4,-1,1,3,5,6,8,11};
            int targetSum = 13;
            Console.WriteLine(TwoNumberSum(array, targetSum));
        }


        
    }
}
