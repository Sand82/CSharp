namespace Generic;
public class Max<T> where T : IComparable<T>
{
    private T one;
    private T two;

    public Max(T one, T two)
    {
        this.one = one;
        this.two = two;
    }

    public T GetMax()
    {
       var result = one.CompareTo(two);

        if (result > 0)
        {
            return one;
        }

        return two;
    }
}
