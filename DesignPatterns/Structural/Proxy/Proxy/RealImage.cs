namespace Proxy;

public class RealImage : IImage
{
    private string? fileName;

    public RealImage(string? fileName)
    {
        this.fileName = fileName;
        LoadFormDisk();
    }

    private void LoadFormDisk()
    {
        Console.WriteLine("Loading image from disk " + fileName);
    }

    public void Display()
    {
        Console.WriteLine("Display image " + fileName);
    }
}
