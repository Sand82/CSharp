namespace Flyweight;

public class Character
{
    private readonly char symbol;

    public Character(char symbol)
    {
        this.symbol = symbol;
    }

    public void Display(int fontSize, string color)
    {
        Console.WriteLine($"Character: {symbol}, FontSize: {fontSize}, Color: {color}");
    }
}
