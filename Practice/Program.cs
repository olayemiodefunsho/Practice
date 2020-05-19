using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            int x = 0;
            int y = 0;

            while(x < array.Count)
            {
                if(array[x] == sequence[y])
                {
                    if(y == sequence.Count - 1)
                    {
                        return true;
                    }
                    x++;
                    y++;
                }
                else
                {
                    x++;
                }
            }
            return false;
        }


        static void Main(string[] args)
        {
            List<int> array = new List<int> { 5,1,22,25,6,-1,8,10};
            List<int> sequence = new List<int> { 1, 6, -1, 10 };

            Console.WriteLine(IsValidSubsequence(array, sequence));
        }


        
    }
}
