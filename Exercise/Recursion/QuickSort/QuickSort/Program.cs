using System;

namespace QuickSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()!.Split(" ").Select(int.Parse).ToList();

            QuickSort(numbers, 0, numbers.Count - 1);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void QuickSort(List<int> numbers, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            var pivot = start;
            var left = start + 1;
            var right = end;

            while (left <= right)
            {
                if (numbers[left] > numbers[pivot] && numbers[right] < numbers[pivot])
                {
                    Swap(numbers, left, right);
                }

                if (numbers[left] <= numbers[pivot])
                {
                    left += 1;
                }

                if (numbers[right] >= numbers[pivot])
                {
                    right -= 1;
                }
            }            

            Swap(numbers, pivot, right);

            QuickSort(numbers, start, right - 1);
            QuickSort(numbers, right + 1, end);
        }

        private static void Swap(List<int> numbers, int left, int right)
        {
            var temp = numbers[left];
            numbers[left] = numbers[right];
            numbers[right] = temp;
        }
    }
}