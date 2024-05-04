using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayGround
{
    public class Program
    {
        private static List<Area> result = new List<Area>();

        private static char[,]? matrix;

        private static int count;

        static void Main(string[] args)
        {

            var rows = int.Parse(Console.ReadLine()!);
            var cols = int.Parse(Console.ReadLine()!);

            matrix = new char[rows, cols];

            FillMatrix();

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    count = 0;

                    Exercise(r, c);

                    if (count > 0)
                    {
                        var area = new Area
                        {
                            Row = r,
                            Col = c,
                            Count = count
                        };

                        result.Add(area);
                    }
                }
            }

            Console.WriteLine($"Total areas found: {result.Count}");

            var sorted = result
                .OrderByDescending(a => a.Count)
                .ThenBy(a => a.Row)
                .ThenBy(a => a.Col)
                .ToList();

            for (int i = 0; i < sorted.Count; i++)
            {
                Console.WriteLine($"Area #{i + 1} at ({sorted[i].Row}, {sorted[i].Col}), size: {sorted[i].Count}");
            }
        }

        private static void Exercise(int row, int col)
        {
            if (IsValidCoordinates(row, col) || IsWall(row, col) || IsFieldCounted(row, col))
            {
                return;
            }

            count++;

            matrix![row, col] = 'v';

            Exercise(row + 1, col);
            Exercise(row - 1, col);
            Exercise(row, col + 1);
            Exercise(row, col - 1);
        }

        private static bool IsFieldCounted(int row, int col)
        {
            return matrix![row, col] == 'v';
        }

        private static bool IsWall(int row, int col)
        {
            return matrix![row, col] == '*';
        }

        private static bool IsValidCoordinates(int row, int col)
        {
            return row < 0 || row >= matrix!.GetLength(0) || col < 0 || col >= matrix!.GetLength(1);
        }

        private static void FillMatrix()
        {
            for (int row = 0; row < matrix?.GetLength(0); row++)
            {
                var input = Console.ReadLine()!;

                for (int col = 0; col < matrix?.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}