namespace Composite;

public abstract class FileSystemItem
{
    protected FileSystemItem(string name)
    {
        Name = name;
    }

    public string? Name { get; set; }

    public abstract void Display(int depth);
}
