using System;
using System.Collections.Generic;

namespace EulerProblems
{
    public static class Problem3
    {
        /*
         * The prime factors of 13195 are 5, 7, 13 and 29.
         * What is the largest prime factor of the number 600851475143 ?
         * */

        public static void Solve()
        {
            var range = 600851475143;
            var primes = GetPrimesInRange(range);
            var dividers = new List<int>();
            foreach (var prime in primes)
            {
                if (range % prime == 0)
                    dividers.Add(prime);
            }
            var largestPrimeFactor = dividers[dividers.Count - 1];

            Console.WriteLine($"Largest prime factor of the number: {range} is {largestPrimeFactor}");
            Console.ReadKey();
        }

        public static List<int> GetPrimesInRange(long range)
        {
            var isPrimeIndicators = new List<bool>();
            for (int i = 0; i < range; i++)
            {
                isPrimeIndicators.Add(true);
            }
            var primes = new List<int>();

            for (int i = 2; i < (int)Math.Sqrt(range); i++)
            {
                if (isPrimeIndicators[i])
                    for (int j = 2 * i; j < range; j += i)
                        isPrimeIndicators[j] = false;
            }

            for (int i = 2; i < isPrimeIndicators.Count; i++)
            {
                if (isPrimeIndicators[i])
                    primes.Add(i);
            }

            return primes;
        }
    }
}