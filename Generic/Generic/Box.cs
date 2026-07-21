namespace Generic;

public class Box<T>
{
    private readonly List<T> values = new List<T>();

    public void Add(T value)
    {
        values.Add(value);
    }

    public void Remove(T value)
    {
        if (values.Count <= 0)
        {
            return;
        }
        values.Remove(value);
    }

    public void Show()
    {
        Console.WriteLine(string.Join(", ", values));
    }

    public void Swap(T valueOne, T valueTwo)
    {
        if (values.Count < 2)
        {
            return;
        }

        var indexOne = values.IndexOf(valueOne);
        var indexTwo = values.IndexOf(valueTwo);

        if ( indexOne == -1 || indexTwo == -1)
        {
            return;
        }

        var temp = values[indexOne];
        values[indexOne] = values[indexTwo]; 
        values[indexTwo] = temp;
    }
}
