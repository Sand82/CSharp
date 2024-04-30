namespace Flyweight
{
    public class Tree
    {
        public Tree(int X, int Y, TreeType type)
        {
            this.XCoordinate = X; 
            this.YCoordinate = Y;
            this.Type = type;
        }

        public int XCoordinate { get; set; }

        public int YCoordinate { get; set; }

        public TreeType Type { get; set; }

        public void Draw(char[,] matrix)
        {
            Type.Draw(this.XCoordinate, this.YCoordinate, matrix);
        }
    }
}
