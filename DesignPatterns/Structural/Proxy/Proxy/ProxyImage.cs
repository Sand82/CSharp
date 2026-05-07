namespace Proxy;

public class ProxyImage : IImage
{
    private IImage? realImage;
    private string? fileName;

    public ProxyImage(string? fileName)
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
