using System;
using System.Collections.Generic;

namespace EulerProblems
{
    public static class Problem2
    {
        //Even Fibonacci numbers
        /*
         * Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
         * 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
         * By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
         */
        public static void Solve()
        {
            var fibbonacciNumbers = new List<long>();
            fibbonacciNumbers.Add(1);
            fibbonacciNumbers.Add(2);
            long evenFbSum = fibbonacciNumbers[1];
            var maxValue = 4_000_000;

            while (true)
            {
                long currentNumber = fibbonacciNumbers[fibbonacciNumbers.Count - 1] + fibbonacciNumbers[fibbonacciNumbers.Count - 2];
                if (currentNumber > maxValue)
                    break;
                fibbonacciNumbers.Add(currentNumber);
                if (currentNumber % 2 == 0)
                    evenFbSum += currentNumber;
            }

            Console.WriteLine($"sum of fibbonaci even number below: {maxValue} is: {evenFbSum}");
            Console.ReadKey();
        }
    }
}