using Action;

var collection = new List<int>() { 1, 1, 3, 3, 5, 6, 7, 3, 9, 2 };
var integerAction = new IntegerActions();
var number = 3;

integerAction.PrintNumberCount((x, col) => PrintNumberCounts(x, col), number, collection);
integerAction.PrintNumber((x, col) => OddNumbers(x, col), number, collection);
integerAction.PrintNumber((x, col) => EvenNumbers(x, col), number, collection);
integerAction.SumArray((col) => SumNumbers(col), collection);

void PrintNumberCounts(int number, List<int> numbers)
{
    var count = numbers.Where(x => x == number).Count();

    Console.WriteLine(count);
}

void OddNumbers(int number, List<int> numbers)
{
    var coll = numbers.Where( x => x % 2 != 0).ToList();

    Console.WriteLine(string.Join(", ", coll));
}

void EvenNumbers(int number, List<int> numbers)
{
    var coll = numbers.Where(x => x % 2 == 0).ToList();

    Console.WriteLine(string.Join(", ", coll));
}

void SumNumbers(List<int> numbers)
{
    var result = numbers.Sum();
    Console.WriteLine(result);
}