namespace Action;

public class IntegerActions
{
    public void PrintNumberCount(Action<int, List<int>> action, int number, List<int> collection)
        => action(number, collection);

    public void PrintNumber(Action<int, List<int>> action, int number, List<int> collection)
        => action(number, collection);

    public void SumArray(Action<List<int>> action, List<int> collection) 
        => action(collection);
}
