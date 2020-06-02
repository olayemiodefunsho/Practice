using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        //ZIG ZAG TRAVERSE - traverse a 2 dimensional array in a zigzag manner
        //at every move check if you are at the edges
        //if you are at the edge alternate the movement either up or down
        //the edge you are at determines if you move down or sideways on the edge
        //if you are not at an edge just keep moving in your current direction
        public static List<int> ZigzagTraverse(List<List<int>> array)
        {

            var return_list = new List<int>();
            int x = 0;
            int y = 0;
            bool point_down = true;

            while(x < array.Count && y < array[0].Count)
            {
                return_list.Add(array[x][y]);
                if(point_down)
                {
                    if(y == 0)
                    {
                        x++;
                        point_down = false;
                        continue;
                    }
                    else
                    {
                        if (x != array.Count - 1)
                        {
                            x++;
                            y--;
                        }
                        else
                        {
                            y++;
                            point_down = false;
                        }
                        continue;
                    }                   
                }
                else
                {
                    if(x == 0)
                    {
                        if (y != array[0].Count - 1) y++;
                        else x++;
                        point_down = true;
                        continue;
                    }
                    else
                    {
                        if(y != array[0].Count - 1)
                        {
                            x--;
                            y++;
                        }
                        else
                        {
                            x--;
                            point_down = true;
                        }
                       
                        continue;
                    }

                }



            }
            
            
            return null;
        }


        static void Main(string[] args)
        {
            var list1 = new List<int>() { 1, 3, 4, 10 };
            var list2 = new List<int>() { 2, 5, 9, 11 };
            var list3 = new List<int>() { 6, 8, 12, 15 };
            var list4 = new List<int>() { 7, 13, 14, 16 };

            var array = new List<List<int>>() { list1, list2, list3, list4 };
            

            var output = ZigzagTraverse(array);

        }



    }
}
