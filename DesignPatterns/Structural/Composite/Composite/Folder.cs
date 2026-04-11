namespace Composite;

public class Folder : FileSystemItem
{
    private List<FileSystemItem> items = new();

    public Folder(string name) : base(name)
    {
    }

    public void Add(FileSystemItem item)
    {       
        items.Add(item);        
    }

    public void Remove(FileSystemItem item)
    {       
        items.Remove(item);       
    }
    
    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + Name);

        foreach (var item in items)
        {
            item.Display(depth + 2);
        }
    }    
}
