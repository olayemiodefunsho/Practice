using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {
            List<int[]> return_array = new List<int[]>();
            Array.Sort(array);

            int x, y;

            for(int i = 0; i < array.Length; i++)
            {
                x = i + 1;
                y = array.Length - 1;

                while (x < y)
                {
                    if (array[x] + array[y] + array[i] == targetSum)
                    {
                        return_array.Add(new int[] { array[i], array[x], array[y]});
                        x++;
                        y--;
                        continue;
                    }

                    if (array[x] + array[y] + array[i] < targetSum)
                    {
                        x++;
                        continue;
                    }

                    if (array[x] + array[y] + array[i] > targetSum)
                    {
                        y--;
                        continue;
                    }
                }


            }

            return return_array;
            
        }


        static void Main(string[] args)
        {
            int[] array = new int[] { -8, -6, 1, 2, 3, 5, 6, 12};
            int targetSum = 0;

            var output = ThreeNumberSum(array, targetSum);
            
        }


        
    }
}
