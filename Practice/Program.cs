using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        public static List<int> MoveElementToEnd(List<int> array, int toMove)
        {
            int x = 0;
            int y = array.Count - 1;
            int holder = 0;

            while (x < y)
            {
                if (array[x] != 2)
                {
                    x++;
                    continue;
                }

                if (array[y] == 2)
                {
                    y--;
                    continue;
                }

                holder = array[x];
                array[x] = array[y];
                array[y] = holder;
                x++;
                y--;
            }



            return array;
        }


        static void Main(string[] args)
        {
            List<int> array = new List<int> { 3, 1, 2, 4, 5 };
            int toMove = 3;



            var output = MoveElementToEnd(array, toMove);
            
        }


        
    }
}
