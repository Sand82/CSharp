using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            var sorted = MergeSort(numbers);

            Console.WriteLine(string.Join(" ", sorted));
        }

        private static int[] MergeSort(int[] numbers)
        {
            if (numbers.Length <= 1)
            {
                return numbers;
            }

            var left = numbers.Take(numbers.Length / 2).ToArray();
            var right = numbers.Skip(numbers.Length / 2).ToArray();

            return Merge(MergeSort(left), MergeSort(right));
        }

        private static int[] Merge(int[] left, int[] right)
        {
            var arr = new int[left.Length + right.Length];

            var mergedIndex = 0;
            var leftIndex = 0;
            var rightIndex = 0;


            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    arr[mergedIndex++] = left[leftIndex++];
                }
                else if(left[leftIndex] > right[rightIndex])
                {
                    arr[mergedIndex++] = right[rightIndex++];
                }
            }

            for (int i = leftIndex; i < left.Length; i++)
            {
                arr[mergedIndex++] = left[i];
            }

            for (int i = rightIndex; i < right.Length; i++)
            {
                arr[mergedIndex++] = right[i];
            }

            return arr;
        }
    }
}