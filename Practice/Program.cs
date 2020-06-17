using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class Program
    {
        //String  - Longest Paloindromic Subsring
        //pick each characer one by one
        //at every chracter check if its the center of a palindrome
        //two ways to check
        //one is for odd lenght and other for even lenght
        //for odd length check the two letters by left and right and expand onwards if they are the same
        //for even lengh check letter before the current letter and expand onwards if they are the same
        //continue to expand till the palindrome ends then get the length
        //continue for all letters till you get the longest string
        public static string LongestPalindromicSubstring(string str)
        {
            string pal = "";
            string holder = "";
            int x = 0; int y = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if(i == 4)
                {

                }
                if(i == 0)
                {
                    pal = str[0].ToString();
                    continue;
                }

                x = i - 1;
                y = i + 1;
                holder = str[i].ToString();

                while(x >= 0 && y <= str.Length - 1)
                {
                    if (str[x] != str[y]) break;
                    else
                    {
                        holder = str[x] + holder + str[y];
                    }
                    x--;
                    y++;
                }

                if (holder.Length > pal.Length) pal = holder;


                x = i - 1;
                y = i;
                holder = "";

                while (x >= 0 && y <= str.Length - 1)
                {
                    if (str[x] != str[y]) break;
                    else
                    {
                        holder = str[x] + holder + str[y];
                    }
                    x--;
                    y++;
                }

                if (holder.Length > pal.Length) pal = holder;



            }
            return pal;
        }


        static void Main(string[] args)
        {
            string str = "abaxyzzyxf";
            var output = LongestPalindromicSubstring(str);
            

        }


    }
}
