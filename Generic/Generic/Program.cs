using Generic;

List<Person> people = new()
   {
       new Person ("Alice", 25),
       new Person ("Bob",  32),
       new Person ("Charlie",18),
       new Person ("David", 40)
   };

Console.WriteLine("Adults:");

var ageFilter = people.MyWhere(p => p.Age > 18).ToList();

foreach (var person in ageFilter)
{
    Console.WriteLine($"{person.Name} ({person.Age})");
}


Console.WriteLine();

Console.WriteLine("Names:");

foreach (var name in people.MySelect(p => p.Name))
{
    Console.WriteLine(name);
}

Console.WriteLine();

var first = people.MyFirst();
Console.WriteLine($"First person: {first.Name}");

Console.WriteLine();

Console.WriteLine($"Any people? {people.MyAny()}");
Console.WriteLine($"Count: {people.MyCount()}");