namespace Generic;

public class MyDictionary<T, V>
{
    private readonly Dictionary<T, V> dictionary = new Dictionary<T, V>();
    
    public void Add(T key, V value)
    {
        dictionary[key] = value;
    }

    public void Remove(T key)
    {
        if (dictionary.ContainsKey(key))
        {
            dictionary.Remove(key);
        }
    }

    public V GetValue(T key)
    {
        if (!dictionary.ContainsKey(key))
        {
            throw new ArgumentException("Key does not exist");
        }
        return dictionary[key];
    }

    public bool ExistKey(T key)
    {
       return dictionary.ContainsKey(key);
    }

    public int GetCount()
    {
        return dictionary.Count;
    }
}
