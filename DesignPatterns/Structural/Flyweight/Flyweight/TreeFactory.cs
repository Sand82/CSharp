using System.Drawing;

namespace Flyweight
{
    public class TreeFactory
    {
        private static List<TreeType> treeTypes = new List<TreeType>();       

        public static TreeType FindTreeType(char symbol)
        {
            var currTreeType = treeTypes.FirstOrDefault(x => x.Symbol == symbol);

            if (currTreeType == null)
            {
                currTreeType = new TreeType(symbol);
                treeTypes.Add(currTreeType);
            }

            return currTreeType;
        }
    }
}
