using System;

namespace Flyweight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var matrix = new char[10, 10];

            SetForest(matrix);

            PlantForest(matrix);

            DrawForest(matrix);
        }

        private static void SetForest(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = '.';
                }                
            }
        }

        private static void PlantForest(char[,] matrix)
        {
            var treeTypeOne = new TreeType('#');
            var treeTypeTwo = new TreeType('@');
            var treeTypeThree = new TreeType('$');
            var treeTypeFour = new TreeType('%');
            var treeTypeFive = new TreeType('&');

            var treeOne = new Tree(1, 1, treeTypeOne);
            var treeTwo = new Tree(2, 5, treeTypeOne);
            var treeThree = new Tree(3, 8, treeTypeTwo);
            var treeFour = new Tree(7, 7, treeTypeTwo);
            var treeFive = new Tree(1, 6, treeTypeThree);
            var treeSix = new Tree(6, 7, treeTypeThree);
            var treeSeven = new Tree(2, 1, treeTypeFour);
            var treeEighth = new Tree(1, 3, treeTypeFour);
            var treeNine = new Tree(4, 1, treeTypeFive);
            var treeTen = new Tree(7, 9, treeTypeFive);

            var forest = new Forest();
            forest.PlantTree(treeOne.XCoordinate, treeOne.YCoordinate, treeOne.Type.Symbol);
            forest.PlantTree(treeTwo.XCoordinate, treeTwo.YCoordinate, treeTwo.Type.Symbol);
            forest.PlantTree(treeThree.XCoordinate, treeThree.YCoordinate, treeThree.Type.Symbol);
            forest.PlantTree(treeFour.XCoordinate, treeFour.YCoordinate, treeFour.Type.Symbol);
            forest.PlantTree(treeFive.XCoordinate, treeFive.YCoordinate, treeFive.Type.Symbol);
            forest.PlantTree(treeSix.XCoordinate, treeSix.YCoordinate, treeSix.Type.Symbol);
            forest.PlantTree(treeSeven.XCoordinate, treeSeven.YCoordinate, treeSeven.Type.Symbol);
            forest.PlantTree(treeEighth.XCoordinate, treeEighth.YCoordinate, treeEighth.Type.Symbol);
            forest.PlantTree(treeNine.XCoordinate, treeNine.YCoordinate, treeNine.Type.Symbol);
            forest.PlantTree(treeTen.XCoordinate, treeTen.YCoordinate, treeTen.Type.Symbol);

            forest.Draw(matrix);
        }

        private static void DrawForest(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
