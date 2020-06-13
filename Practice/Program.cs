using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        //ZIG ZAG TRAVERSE - traverse a 2 dimensional array in a zigzag manner
        //when going up check if we are by the left or bottom perimeter
        //when going down check if we ar at the right or top perimeter
        //else just move diagnally depending on up or down minue or plus x and y as needed
        // at the perimeters come down or go right till the end
        public static List<int> ZigzagTraverse(List<List<int>> array)
        {

            var return_list = new List<int>();
            int x = 0;
            int y = 0;
            bool point_down = true;

            while(x < array.Count && y < array[0].Count)
            {                
                if(point_down)
                {
                    if(x == array.Count - 1 || y == 0)
                    {
                        if (y == 0 && x != array.Count - 1)
                        {
                            point_down = false;
                            return_list.Add(array[x][y]);
                            x++;
                            continue;
                        }
                        if (x == array.Count - 1)
                        {
                            point_down = false;
                            return_list.Add(array[x][y]);
                            if (y != array[0].Count - 1) y++;
                            else break;
                            continue;
                        }
                    }
                    else
                    {
                        return_list.Add(array[x][y]);
                        x++;
                        y--;
                    }                                      
                }
                else
                {
                    if(x == 0 || y == array[0].Count - 1)
                    {
                        if (x == 0 && y != array[0].Count - 1)
                        {
                            point_down = true;
                            return_list.Add(array[x][y]);
                            y++;
                            continue;
                        }                  
                        if (y == array[0].Count - 1)
                        {
                            point_down = true;
                            return_list.Add(array[x][y]);
                            if (x != array.Count - 1) x++;
                            else break;
                            return_list.Add(array[x][y]);
                            x++;
                            if (y != 0) y--;                        
                            continue;
                        }

                    }
                    else
                    {
                        return_list.Add(array[x][y]);
                        x--;
                        y++;
                    }                    
                                       
                }
            }            
            return return_list;
        }


        static void Main(string[] args)
        {
            var list1 = new List<int>() {1};
            //var list2 = new List<int>() {2};
            //var list3 = new List<int>() {3};
            //var list4 = new List<int>() {4};
            //var list5 = new List<int>() {5};

            //var list1 = new List<int>() { 1, 3, 4, 10 };
            //var list2 = new List<int>() { 2, 5, 9, 11 };
            //var list3 = new List<int>() { 6, 8, 12, 15 };
            //var list4 = new List<int>() { 7, 13, 14, 16 };

            var array = new List<List<int>>() { list1};
            

            var output = ZigzagTraverse(array);

        }



    }
}
