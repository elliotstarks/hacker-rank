using System;

namespace RepeatingString
{
    class Result
    {

        /*
         * Complete the 'repeatedString' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. STRING s
         *  2. LONG_INTEGER n
         */

        public static long repeatedString(string s, long n)
        {
            long numLetterA = 0;
            long numLetterAInStr = 0;
            long numLetterAInLeftOver = 0;
            long iterationsOfStr = n / s.Length;
            long leftOverChars = n % s.Length;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    numLetterAInStr++;

                    if ((long)i < leftOverChars)
                    {
                        numLetterAInLeftOver++;
                    }
                }
            }

            numLetterA = numLetterAInStr * iterationsOfStr + numLetterAInLeftOver;

            return numLetterA;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.repeatedString(s, n);

            Console.WriteLine(result);
        }
    }

}
