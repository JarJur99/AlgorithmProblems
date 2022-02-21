using System;

namespace EulerProblems
{
    public static class Problem6
    {
        /*
         * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
         */

        public static void Solve()
        {
            int range = 100;

            long sumOfSquares = 0;
            long squareofSum = 0;
            long diff;

            for (int i = 1; i <= range; i++)
            {
                sumOfSquares += (i * i);
                squareofSum += i;
            }

            squareofSum *= squareofSum;
            diff = squareofSum - sumOfSquares;

            Console.WriteLine(diff);
            Console.ReadKey();
        }
    }
}