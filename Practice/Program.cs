using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        //String  - Ceasar Cipher Encryptor
        //calculate key by using key modulo 26
        //that gives number of steps forward we will go
        //create a string of all alphabets
        //iterate through every character in the given string
        //if the index of the current character plus key is greater than 25
        //minus 25 from the sum to get new index
        //convert new index back to character and append to new string
        public static string CaesarCypherEncryptor(string str, int key)
        {
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            int realKey = key % 26;
            int sum = 0;
            var strBuilder = new System.Text.StringBuilder();

            foreach(var item in str)
            {
                sum = alpha.IndexOf(item) + realKey;
                if (sum > 25) sum -= 26;
                strBuilder.Append(alpha[sum]);

            }

            return strBuilder.ToString();
        }


        static void Main(string[] args)
        {
            string str = "xyz";
            int key = 3;
            var output = CaesarCypherEncryptor(str, key);
            

        }


    }
}
