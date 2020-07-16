using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class Program
    {
        public static int[] SearchInSortedMatrix(int[,] matrix, int target)
        {
            int x = 0, y = matrix.GetLength(0), maxy = y, maxx = matrix.GetUpperBound(0);
            while((x <= maxx && x >= 0) && (y <= maxy && y >= 0))
            {
                if(matrix[x,y] == target)
                {
                    return new int[] { x, y };
                }

                if(target > matrix[x, y])
                {
                    x++;
                    continue;
                }

                if(target < matrix[x, y])
                {
                    y--;
                    continue;
                }
            }

            return new int[] { -1, -1 };
        }

        static void Main(string[] args)
        {            
            var array = new int[,]
            {
               { 1, 4, 7, 12, 15, 1000 },
               { 2, 5, 19, 31, 32, 1001 },
               { 3, 8, 24, 33, 35, 1002 },
               { 40, 41, 42, 44, 45, 1003 },
               { 99, 100, 103, 106, 128, 1004 }

            };
            int target = 43;
            var output = SearchInSortedMatrix(array, target);           
        }
    }
}
