using Predicate;

var stringChecker = new LengthChecker("Make it simple");

var result = stringChecker
    .IsStringLong(new Predicate<string>(x => x.Length > 5));

var hasTheStringCharacter = stringChecker
    .HasStringWantedCharacter(x => stringChecker.GetString().Contains(x), 'A');

var number = 10;
var hasWantedNumber = stringChecker
    .HasWantedNumber(x => HasNumber(stringChecker.IntToCheck, number), number);

Console.WriteLine(result);
Console.WriteLine(hasTheStringCharacter);
Console.WriteLine(hasWantedNumber);

bool HasNumber(List<int> numbers, int number)
{
    var result = numbers.Any(x => x == number);
    return result;
}