using Flyweight;

var characterFactory = new CharacterFactory();

var input = "ABBACCCABCAAABBCC";

foreach (var item in input)
{
    var character = characterFactory.GetCharacter(item);
    var fontSize = GetFontSize(item);
    var color = GetColor(item);

    character.Display(fontSize, color);
}

int GetFontSize(char character)
{
    switch (character)
    {
        case 'A':
            return 10;
        case 'B':
            return 11;
        case 'C':
            return 12;
        default:
            return 16;
    }
}

string GetColor(char character)
{
    switch (character)
    {
        case 'A':
            return "Red";
        case 'B':
            return "Blue";
        case 'C':
            return "Black";
        default:
            return "Green";
    }
}