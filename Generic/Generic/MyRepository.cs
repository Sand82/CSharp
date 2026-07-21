namespace Generic;
public class MyRepository<T> 
    where T : class
{
    private readonly List<T> items = new List<T>();

    public void Add(T item)
    {
        this.items.Add(item);
    }

    public T Remove(T item) 
    { 
        var index = this.items.IndexOf(item);

        if (index == -1)
        {
            throw new InvalidOperationException("There is no such element");
        }

        var element = this.items[index];
        items.RemoveAt(index);

        return element;
    }

    public List<T> GetAll()
    {
        return this.items;
    }

    public bool Find(Predicate<T> predicate) 
    {
       return items.Any(x => predicate(x));           
    }        
}
