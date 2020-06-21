using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class Program
    {
        //String - Longest Substring without duplication
        //Have a variable that will always hold the starting index of longest substring
        //Initialize the variable to zero
        //Have a string builder to concatenate longest string as we proceed or clear as necessary
        //Have a Hash table to store the first occurence of every string and the index
        //traverse the string and check if each letter is already in the hash table
        //if you find a letter already there, find the max of startindex and index of letter plus 1
        //
        public static string LongestSubstringWithoutDuplication(string str)
        {
            var sb = new StringBuilder();
            string longest_str = "";
            string new_str = "";
            var ht = new Dictionary<char, int>();

            if(str.Length == 1) return str;

            for(int i = 0; i < str.Length; i++)
            {                  
                if(ht.ContainsKey(str[i]))
                {
                    new_str = sb.ToString();
                    if(new_str.Length > longest_str.Length) longest_str = new_str;
                    sb.Clear();
                    sb.Append(str[i - 1]);
                    sb.Append(str[i]);
                    ht.Clear();
                    ht[str[i - 1]] = i - 1;
                    ht[str[i]] = i;
                }
                else
                {
                    ht[str[i]] = i;
                    sb.Append(str[i]);
                }

                if (i == str.Length - 1 && sb.Length > longest_str.Length) longest_str = sb.ToString();
            }
            // Write your code here
            return longest_str;
        }

        static void Main(string[] args)
        {
            var str = "abcdeabcdefc";
            var output = LongestSubstringWithoutDuplication(str);
            

        }


    }
}
