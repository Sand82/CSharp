using System.ComponentModel;
using System.Xml.Schema;

namespace Flyweight
{
    public class TreeType
    {      
        public TreeType(char symbol)
        {
            this.Symbol = symbol;
        }

        public char Symbol { get; set; }

        public void Draw(int x, int y, char[,] matrix)
        {
            matrix[x,y] = this.Symbol;

            Console.WriteLine($"Planting tree on {x} and {y} coordinates.");
        }
    }
}
