using System;
using System.Collections.Generic;
using System.Linq;

namespace BinarySearchRecursive
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

            var left = 0;
            var right = numbers.Length - 1;

            Console.WriteLine(BinarySearch(n, left, right));
        }

        private static bool BinarySearch(int n, int left, int right)
        {
            if (left >= right)
            {
                return false;
            }

            var middle = (left + right) / 2;
            var element = numbers[middle];

            if (element == n)
            {
                return true;
            }

            if (n > element)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }

            return BinarySearch(n, left, right);
        }
    }
}