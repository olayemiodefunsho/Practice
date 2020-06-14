using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        //NTH FIBONACCI
        //if n is 1 return 0 and if n is 2 return 1
        //Initialize 2 dimensinal array with 0 and 1
        //add the 2 numbers to get the next fib number
        //remove index 0, move index 1 to index 0 and put the new fibonacci number in index 1
        //repart the same for the number of ns
        public static int GetNthFib(int n)
        {
            if(n == 1) return 0;
            if (n == 2) return 1;

            var array = new int[] { 0, 1 };

            int i = 2;
            int sum = 0;
            while(i < n)
            {
                sum = array[0] + array[1];
                array[0] = array[1];
                array[1] = sum;
                i++;
            }

            return array[1];
        }


        static void Main(string[] args)
        {
            int n = 6;            
            var output = GetNthFib(n);

        }



    }
}
