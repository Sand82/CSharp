namespace AbstractFactory.IndoorActivities;

public class IndoorFactory : IFactory
{
    public IGame CreateIGame()
    {
        return new Chess();
    }

    public ISport CreateISport()
    {
        return new TableTennis();
    }
}
