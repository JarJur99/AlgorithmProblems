using System;

namespace EulerProblems
{
    public static class Problem5
    {
        /*
        *  2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        *  What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        */

        public static void Solve()
        {
            int largestNumberInRange = 20;
            int currentNumber = largestNumberInRange;

            while (true)
            {
                bool dividedByAllNumbers = true;

                for (int i = 2; i <= largestNumberInRange; i++)
                {
                    if (currentNumber % i != 0)
                    {
                        dividedByAllNumbers = false;
                        break;
                    }
                }

                if (dividedByAllNumbers)
                    break;

                currentNumber += largestNumberInRange;
            }

            Console.WriteLine($"Smallest positive number evenly divisible by all numbers 1..{largestNumberInRange} is: {currentNumber}");
            Console.ReadKey();
        }
    }
}