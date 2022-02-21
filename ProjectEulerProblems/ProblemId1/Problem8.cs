using System;
using System.IO;
using System.Linq;

namespace EulerProblems
{
    public static class Problem8
    {
        public static void Solve()
        {
            int lengthOfSequence = 13;

            string number = "";
            using (StreamReader sr = new StreamReader("../../../ProblemConnectedFiles/1000-digit_number.txt"))
                number = sr.ReadToEnd();
            var numbers = number.Split('0').Where(x => x.Length >= lengthOfSequence).ToList(); // if there is 0 in sequence the product is equal to 0;

            long greatestProduct = 0;
            string sequenceForProduct = "";

            foreach (var num in numbers)
            {
                for (int i = 0; i <= num.Length - lengthOfSequence; i++)
                {
                    long currentProduct = 1;

                    for (int j = i; j < lengthOfSequence + i; j++)
                        currentProduct *= int.Parse(num[j].ToString());

                    if (currentProduct > greatestProduct)
                    {
                        greatestProduct = currentProduct;
                        sequenceForProduct = num.Substring(i, lengthOfSequence);
                    }
                }
            }

            Console.WriteLine($"The greatest product is: {greatestProduct} for sequence: {sequenceForProduct}");
            Console.ReadKey();
        }
    }
}