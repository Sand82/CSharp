namespace Flyweight
{
    public class Forest
    {
        public Forest()
        {
            this.Trees = new List<Tree>();
        }

        public ICollection<Tree> Trees { get; set; }

        public void PlantTree(int x, int y, char symbol)
        {
            var type = TreeFactory.FindTreeType(symbol);

            var tree = new Tree(x, y, type);

            Trees.Add(tree);
        }

        public void Draw(char[,] matrix)
        {
            foreach (var tree in Trees) 
            { 
                tree.Draw(matrix);
            }
        }
    }
}
