namespace Proxy;

public class ProxiImage : IImage
{
    private IImage? realImage;
    private string? fileName;

    public ProxiImage(string? fileName)
    {
        this.fileName = fileName;
    }

    public void Display()
    {
        if (realImage == null)
        {
            realImage = new RealImage(fileName);
        }

        realImage.Display();
    }
}
