namespace Composite;

public class File : FileSystemItem
{
    public File(string name) : base(name)
    {
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + Name);
    }
}
