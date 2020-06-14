using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        //String  - Palindrome check
        //put a pointer on the first and last string
        //keep comparong both and moving closer till thy meet
        //if at any point they differ fail and return false
        //if it gets to the end return true, that's a palindrome
        public static bool IsPalindrome(string str)
        {
            bool return_value = true;
            int i = 0;
            int j = str.Length - 1;
            while(i < j)
            {
                if (str[i] != str[j]) return false;
                i++;
                j--;
            }

            return return_value;
        }


        static void Main(string[] args)
        {
            string str = "abcdcba";
            var output = IsPalindrome(str);
            

        }


    }
}
