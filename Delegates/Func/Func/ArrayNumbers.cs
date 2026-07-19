namespace Func;

public class ArrayNumbers
{
    private readonly IEnumerable<int> collection = new List<int> { 15, 2, 3, 10 , 22 ,17, 36, 58, 29, 78, 20, 15 };

    public IEnumerable<int> NumbersManipulation(Func<IEnumerable<int>, IEnumerable<int>> func)
        => func(collection);
}
