using System;

namespace CountingValleys
{
    class Result
    {

        /*
         * Complete the 'countingValleys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER steps
         *  2. STRING path
         */

        public static int countingValleys(int steps, string path)
        {
            bool isBelowSeaLevel = false;
            int depth = 0;
            int numValleys = 0;

            foreach (char step in path)
            {
                if (step == 'D')
                {
                    depth--;
                }
                else if (step == 'U')
                {
                    depth++;
                }

                if (depth == 0 && isBelowSeaLevel)
                {
                    numValleys++;
                }
                else if (depth < 0)
                {
                    isBelowSeaLevel = true;
                }
                else if (depth > 0)
                {
                    isBelowSeaLevel = false;
                }
            }

            return numValleys;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = Result.countingValleys(steps, path);

            Console.WriteLine(result);
        }
    }

}
