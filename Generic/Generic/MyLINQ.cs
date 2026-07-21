namespace Generic;
public static class MyLINQ
{

    public static IEnumerable<T> MyWhere<T>
        (this IEnumerable<T> source, Func<T, bool> predicate)
    {
        foreach (var item in source)
        {
            if (predicate(item))
            {
                yield return item;
            }
        }
    }

    public static IEnumerable<TResult> MySelect<TSource, TResult>
        (this IEnumerable<TSource> sources, Func<TSource, TResult> selector)
    {
        foreach (var item in sources)
        {
            yield return selector(item);
        }
    }

    public static T MyFirst<T>(this IEnumerable<T> source )
    {
        foreach(var item in source)
        {
            return item;
        }

        throw new InvalidOperationException("Sequence contains no elements.");
    }

    public static bool MyAny<T>(this IEnumerable<T> source)
    {
        foreach (var item in source)
        {
            return true;
        }

        return false;
    }

    public static int MyCount<T>(this IEnumerable<T> source)
    {
        var count = 0;  

        foreach (var item in source)
        {
            count++;
        }

        return count;
    }
}
