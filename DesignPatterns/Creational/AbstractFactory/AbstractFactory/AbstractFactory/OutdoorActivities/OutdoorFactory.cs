namespace AbstractFactory.OutdoorActivities;

public class OutdoorFactory : IFactory
{
    public IGame CreateIGame()
    {
        return new CaptureTheFlag();
    }

    public ISport CreateISport()
    {
        return new Football();
    }
}
