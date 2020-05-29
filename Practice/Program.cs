using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        public static List<int[]> FourNumberSum(int[] array, int targetSum)
        {
            var return_list = new List<int[]>();
            var holder_dic = new Dictionary<int, List<int[]>>();
            int key, j;
            List<int[]> int_list;
            bool if_exist = false;

            for (int i = 1; i < array.Length - 1; i++)
            {                             
                for(j = i + 1; j <= array.Length - 1; j++)
                {
                    key = targetSum - (array[i] + array[j]);
                    if (holder_dic.ContainsKey(key))
                    {
                        foreach(var item in holder_dic[key])
                        {
                            return_list.Add(new int[] { item[0], item[1],array[i], array[j]});
                        }                      
                    }                   
                }

                for(j = 0; j < i; j++)
                {
                    int_list = new List<int[]>();
                    key = array[i] + array[j];
                    if (!holder_dic.ContainsKey(key))
                    {
                        int_list.Add(new int[] { array[j], array[i] });
                        holder_dic.Add(key, int_list);
                    }
                    else
                    {
                        foreach (var item in holder_dic[key])
                        {
                            if((array[i] == item[0] && array[j] == item[1]) || (array[j] == item[0] && array[i] == item[1]))
                            {
                                if_exist = true;
                                break;
                            }
                        }

                        if(!if_exist)
                        {
                            holder_dic[key].Add(new int[] { array[j], array[i] });
                        }
                    }

                }

            }
            // Write your code here.
            return return_list;
        }


        static void Main(string[] args)
        {
            int[] array = new int[] { 5, -5, -2, 2, 3, -3 };
            int targetSum = 0;

            var output = FourNumberSum(array, targetSum);

        }



    }
}
