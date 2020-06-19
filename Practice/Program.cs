using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class Program
    {
        //Searching - Three Largest Numbers
        //Initialize an array of 3 items
        //Pick each item in the input array one by one
        //first compare to item at index 2 which is the largest, if it larger replace and move every other number to the left
        //if it is less compare to index 1 and so on and so forth
        //return the array of 3 items
        public static int[] FindThreeLargestNumbers(int[] array)
        {
            var return_array = new int[] { Int32.MinValue, Int32.MinValue, Int32.MinValue};


            foreach(var item in array)
            {
                if(item > return_array[2])
                {
                    return_array[0] = return_array[1];
                    return_array[1] = return_array[2];
                    return_array[2] = item;
                }
                else
                {
                    if (item > return_array[1])
                    {
                        return_array[0] = return_array[1];
                        return_array[1] = item;
                    }
                    else
                    {
                        if (item > return_array[0])
                        {
                            return_array[0] = item;
                        }
                    }
                }
            }

            return return_array;
        }


        static void Main(string[] args)
        {
            var array = new int[] { 55,7,8 };
            var output = FindThreeLargestNumbers(array);
            

        }


    }
}
