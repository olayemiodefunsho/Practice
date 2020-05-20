using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);
            var return_array = new int[2];

            int x = 0;
            int y = 0;

            int difference = int.MaxValue;
            int holder = 0;


            while (x < arrayOne.Length && y < arrayTwo.Length)
            {
                if(arrayOne[x] == arrayTwo[y])
                {
                    return_array[0] = arrayOne[x];
                    return_array[1] = arrayTwo[y];
                }

                if(arrayOne[x] < arrayTwo[y])
                {
                    holder = arrayTwo[y] - arrayOne[x];
                    if(holder < difference)
                    {
                        difference = holder;
                        return_array[0] = arrayOne[x];
                        return_array[1] = arrayTwo[y];
                    }
                    x++;
                }
                else
                {
                    holder = arrayOne[x] - arrayTwo[y];
                    if (holder < difference)
                    {
                        difference = holder;
                        return_array[0] = arrayOne[x];
                        return_array[1] = arrayTwo[y];
                    }
                    y++;
                }
            }


            return return_array;
        }


        static void Main(string[] args)
        {
            int[] arrayOne = new int[] {-1, 3, 5, 10, 20, 28};
            int[] arrayTwo = new int[] { 15, 17, 26, 134, 135};
            

            var output = SmallestDifference(arrayOne, arrayTwo);
            
        }


        
    }
}
