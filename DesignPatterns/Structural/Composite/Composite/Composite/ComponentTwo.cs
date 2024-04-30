namespace Composite
{
    public class ComponentTwo : INumber
    {
        private int twoNum = 2 * 10;

        private List<INumber> children;

        public ComponentTwo()
        {
            children = new List<INumber>();
        }

        public void AddChild(INumber child)
        {
            children.Add(child);
        }

        public void RemoveChild(INumber child)
        {
            var index = children.IndexOf(child);

            if (index == -1)
            {
                throw new ArgumentException("Child not found.");
            }

            children.RemoveAt(index);
        }

        public int GetNumber()
        {
            var result = twoNum;

            foreach (var child in children)
            {
                result += child.GetNumber();
            }

            return result;
        }
    }
}
