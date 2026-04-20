using Flyweight;

var factory = new CharacterFactory();

var text = "ACABBCABBA";

foreach (char c in text)
{
    var character = factory.GetCharacter(c);

    character.Display(fontSize: 12, color: "Black");
}