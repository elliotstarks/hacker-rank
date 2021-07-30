using System.Collections.Generic;
using System.Linq;
using System;

namespace SockMerchant
{

    class Result
    {

        /*
         * Complete the 'sockMerchant' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER_ARRAY ar
         */

        public static int sockMerchant(int n, List<int> ar)
        {
            int numPairs = 0;
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int val = ar[i];
                int dups = 1;

                if (dict.ContainsKey(val))
                {
                    dups = dict[val] + 1;
                }

                dict[val] = dups;
            }

            foreach (var entry in dict)
            {
                numPairs += entry.Value / 2;
            }

            return numPairs;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = Result.sockMerchant(n, ar);

            Console.WriteLine(result);
        }
    }

}
