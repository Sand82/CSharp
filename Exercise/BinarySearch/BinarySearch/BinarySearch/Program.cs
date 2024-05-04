using System;
using System.Collections.Generic;
using System.Linq;

namespace BinarySearch
{
    public class Program
    {
        private static int[] numbers;

        static void Main(string[] args)
        {
            var numbersInput = Console.ReadLine()!
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            numbers = numbersInput.OrderBy(x => x).ToArray();

            var n = int.Parse(Console.ReadLine()!);

            var result = BinarySearch(n);

            Console.WriteLine(BinarySearch(n));
        }

        private static bool BinarySearch(int n)
        {
            var left = 0;
            var right = numbers.Length - 1;

            while (left <= right)
            {
                var middle = (left + right) / 2;

                var currNumber = numbers[middle];

                if (currNumber == n)
                {
                    return true;
                }

                if (n > currNumber)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return false;
        }
    }
}