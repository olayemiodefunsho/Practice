using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        //MIN REWARDS - minimiun reward you can give to members of an array deoending on their score
        //create an array with same size and fill with all 1s
        //go thru scores from left to right
        //For every element that is greater than the one before it
        //update it's value in array with which ever is greater
        //between it's value and the one before it plus 1
        //now run from right to left
        //For every element that is greater than the one before it
        //update array with max just as above
        //npw return the sum of all elements in array
        public static int MinRewards(int[] scores)
        {
            var array = new int[scores.Length];
            Array.Fill(array, 1);

            for(int i = 1; i < scores.Length; i++)
            {
                if(scores[i] > scores[i - 1])
                {
                    array[i] = Math.Max(array[i], array[i - 1] + 1);
                }
            }

            for (int i = scores.Length - 2; i >= 0; i--)
            {
                if (scores[i] > scores[i + 1])
                {
                    array[i] = Math.Max(array[i], array[i + 1] + 1);
                }
            }


            return array.Sum();
        }


        static void Main(string[] args)
        {
            int[] scores = new int[] { 8,4,2,1,3,6,7,9,5};

            var output = MinRewards(scores);

        }



    }
}
