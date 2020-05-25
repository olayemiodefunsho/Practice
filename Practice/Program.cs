using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        public static List<int> SpiralTraverse(int[,] array)
        {
            int sc = 0;
            int ec = array.GetLength(1) - 1;
            int sr = 0;
            int er = array.GetLength(0) - 1;

            var return_list = new List<int>();

            while(sr <= er && sc <= ec)
            {
                for (int i = sc; i <= ec; i++)
                {
                    return_list.Add(array[sr, i]);
                }

                if (sr == er) break;

                for (int i = sr + 1; i <= er; i++)
                {
                    return_list.Add(array[i, ec]);
                }

                if (sc == ec) break;

                for (int i = ec - 1; i >= sc; i--)
                {
                    return_list.Add(array[er, i]);
                }

                for (int i = er - 1; i >= sr + 1; i--)
                {
                    return_list.Add(array[i, sc]);
                }

                sc++;
                ec--;
                sr++;
                er--;
            }

            return return_list;


        }


        static void Main(string[] args)
        {
            int[,] array = new int[,] { { 1, 2, 3 }, { 12, 13, 4 }, { 11, 14, 5 }, { 10, 15, 6 }, { 9, 8, 7 } };         

            var output = SpiralTraverse(array);

        }



    }
}
