using System;

namespace EulerProblems
{
    /*
     * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
     * Find the largest palindrome made from the product of two 3-digit numbers.
     */

    public static class Problem4
    {
        public static void Solve()
        {
            int largestPalindrome = 0;

            for (int i = 999; i > 0; i--)
            {
                for (int j = 999; j > 0; j--)
                {
                    int currentNumber = i * j;
                    int reversedNumber = ReverseNumber(currentNumber);
                    bool isPalindrome = currentNumber - reversedNumber == 0;

                    if (isPalindrome)
                    {
                        largestPalindrome = currentNumber;
                        break;
                    }
                }

                if (largestPalindrome != 0)
                    break;
            }

            Console.WriteLine($"Largest palindrome number made from the product of two 3-digit numbers is: {largestPalindrome}");
            Console.ReadKey();
        }

        public static int ReverseNumber(int number)
        {
            var numberChars = number.ToString().ToCharArray();
            Array.Reverse(numberChars);
            return int.Parse(String.Concat(numberChars));
        }
    }
}