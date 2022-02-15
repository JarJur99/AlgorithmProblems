using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemId1
{
    class Program
    {
        // Multiples of 3 or 5
        /* 
         * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
         * Find the sum of all the multiples of 3 or 5 below 1000.
         */

        static void Main(string[] args)
        {
            int numberToSolve = 1_000;
            var multiples = new List<long>();
            long solution = 0;

            for (int i = 0; i < numberToSolve; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    multiples.Add(i);
            }

            solution = multiples.Sum();
            Console.WriteLine($"Sum of all multiples below {numberToSolve} = {solution}");
            Console.ReadKey();
            
        }
    }
}
