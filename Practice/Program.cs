using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 19, -1,
    18,
    17,
    2,
    10,
    3,
    12,
    5,
    16,
    4,
    11,
    8,
    7,
    6,
    15,
    12,
    12,
    2,
    1,
    6,
    13,
    14 };
            var return_list = new List<int>();
            var input_dic = new Dictionary<int, bool>();
            foreach(var item in array)
            {
                if (!input_dic.ContainsKey(item)) input_dic.Add(item, false);
            }

            List<int> item_list;

            foreach (int item in array)
            {
                if (input_dic[item]) continue;
                else
                {
                    item_list = new List<int>();
                    input_dic[item] = true;
                    item_list.Add(item);
                    int i = 1;
                    while (true)
                    {
                        if (input_dic.ContainsKey(item - i))
                        {
                            item_list.Add(item - i);
                            input_dic[item - i] = true;
                        }
                        else break;

                        i++;
                    }

                    i = 1;
                    while (true)
                    {
                        if (input_dic.ContainsKey(item + i))
                        {
                            item_list.Add(item + i);
                            input_dic[item + i] = true;
                        }
                        else break;

                        i++;
                    }


                }

                if(item_list.Count > return_list.Count)
                {
                    return_list = item_list;
                }
                
                  
            }

            var return_array = new int[2] { return_list.Min(), return_list.Max() };

             Console.WriteLine(return_list.ToArray());




        }
    }
}
