using System.Collections.Generic;
using System.Linq;
using System;

namespace JumpingOnTheClouds
{
    class Result
    {

        /*
         * Complete the 'jumpingOnClouds' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY c as parameter.
         */

        public static int jumpingOnClouds(List<int> c)
        {
            /* Iterative Solution */

            // int numJumps = 0;
            // int currCloud = 0;
            // int totalClouds = c.Count;

            // while (currCloud < totalClouds - 1)
            // {
            //     if (currCloud >= totalClouds - 3 || c[currCloud + 2] == 0)
            //     {
            //         numJumps++;
            //         currCloud += 2;
            //     }
            //     else if (c[currCloud + 1] == 0)
            //     {
            //         numJumps++;
            //         currCloud += 1;
            //     }
            // }

            // return numJumps;


            /* Recursive Solution */

            if (c.Count == 1)
            {
                return 0;
            }

            if (c.Count == 2)
            {
                return 1 + jumpingOnClouds(c.Skip(1).Take(c.Count - 1).ToList());
            }

            if (c[2] == 0)
            {
                return 1 + jumpingOnClouds(c.Skip(2).Take(c.Count - 2).ToList());
            }
            else
            {
                return 1 + jumpingOnClouds(c.Skip(1).Take(c.Count - 1).ToList());
            }
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

            int result = Result.jumpingOnClouds(c);

            Console.WriteLine(result);
        }
    }

}
