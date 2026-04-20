namespace Flyweight;

public class CharacterFactory
{
    private readonly Dictionary<char, Character> characters = new Dictionary<char, Character>();

    public Character GetCharacter(char key)
    {
        if (!characters.ContainsKey(key))
        {
            characters[key] = new Character(key);
            Console.WriteLine($"Creating new Character object for '{key}'");
        }

        return characters[key];
    }
}
