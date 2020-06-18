using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class Program
    {
        //String  - Group Anagrams
        //pick each string one after the other
        //create a hash table string key and list of string value
        //sort the string and check if the sorted string is a key in the hash table
        //if it is add to the list of string value
        //if not create a new key and add the unsorted string to the list of string value
        //when done with all string return all values in the hash table as a list of list of string
        public static List<List<string>> groupAnagrams(List<string> words)
        {
            var holder = new Dictionary<string, List<string>>();
           
            var str = new StringBuilder();

            foreach (var word in words)
            {
                string key = "";
                var char_array = word.ToCharArray();
                Array.Sort(char_array);

                foreach(var xter in char_array) str.Append(xter);
                key = str.ToString();
                str.Clear();

               

                if (holder.ContainsKey(key))
                {
                    holder[key].Add(word);
                }
                else
                {
                    holder[key] = new List<string> { word };
                }
            }


            var return_list = new List<List<string>>();

            foreach(var item in holder.Keys)
            {
                return_list.Add(holder[item]);
            }

            return return_list;
        }


        static void Main(string[] args)
        {
            var words = new List<string> { "yo", "act", "flop", "tac", "cat", "oy", "olfp" };
            var output = groupAnagrams(words);
            

        }


    }
}
