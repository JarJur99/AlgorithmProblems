using System;

namespace ProblemId1
{
    internal class Program
    {
        // Multiples of 3 or 5
        /*
         * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
         * Find the sum of all the multiples of 3 or 5 below 1000.
         */

        private static void Main(string[] args)
        {
            int numberToSolve = 1_000;
            long solution = 0;

            for (int i = 0; i < numberToSolve; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    solution += i;
            }

            Console.WriteLine($"Sum of all multiples below {numberToSolve} = {solution}");
            Console.ReadKey();
        }
    }
}