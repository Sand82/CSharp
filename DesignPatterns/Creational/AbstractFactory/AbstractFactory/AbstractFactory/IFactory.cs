namespace AbstractFactory;

public interface IFactory
{
    public IGame CreateIGame();

    public ISport CreateISport();
}
