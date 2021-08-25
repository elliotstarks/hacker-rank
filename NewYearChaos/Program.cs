using System;
using System.Collections.Generic;
using System.Linq;

namespace NewYearChaos
{
    class Result
    {

        /*
         * Complete the 'minimumBribes' function below.
         *
         * The function accepts INTEGER_ARRAY q as parameter.
         */

        public static void minimumBribes(List<int> q)
        {
            string result = "Too chaotic";

            int bribes = 0;
            bool isValid = true;

            for (int i = 0; i < q.Count; i++)
            {
                int myBribes = q[i] - (i + 1);
                if (myBribes > 2)
                {
                    isValid = false;
                    break;
                }

                int twoBribesAway = q[i] - 2;
                if (twoBribesAway < 0)
                {
                    twoBribesAway = 0;
                }

                for (int j = twoBribesAway; j < i; j++)
                {
                    if (q[j] > q[i])
                    {
                        bribes++;
                    }
                }
            }

            if (isValid)
            {
                result = bribes.ToString();
            }

            Console.WriteLine(result);
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

                Result.minimumBribes(q);
            }
        }
    }
}
