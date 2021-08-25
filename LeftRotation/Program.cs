using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRotation
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System;

    class Result
    {

        /*
         * Problem: https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
         * Complete the 'rotLeft' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER d
         */

        public static List<int> rotLeft(List<int> a, int d)
        {
            var queue = new Queue<int>(a);

            for (int i = 0; i < d; i++)
            {
                queue.Enqueue(queue.Dequeue());   
            }

            return queue.ToList();
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> result = Result.rotLeft(a, d);

            Console.WriteLine(String.Join(" ", result));
        }
    }

}
