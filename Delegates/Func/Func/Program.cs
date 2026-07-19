using Func;
using System.Linq;

var arrayNumbers = new ArrayNumbers();

 var sortedDescendingColl = arrayNumbers
    .NumbersManipulation(x => x.OrderByDescending(e => e).ToList());

var sortedAscendingColl = arrayNumbers
    .NumbersManipulation(x => x.OrderBy(e => e).ToList());

var oddNumbers = arrayNumbers
    .NumbersManipulation(x => x.Where(y => y % 2 != 0).ToList());

var evenNumbers = arrayNumbers
    .NumbersManipulation(x => x.Where(y => y % 2 == 0).ToList());

var number = 15;

var numberCount = arrayNumbers
    .NumbersManipulation(x => x.Where(y => y == number).ToList());

Console.WriteLine(string.Join(", ", sortedDescendingColl));
Console.WriteLine(string.Join(", ", sortedAscendingColl));
Console.WriteLine(string.Join(", ", oddNumbers));
Console.WriteLine(string.Join(", ", evenNumbers));
Console.WriteLine(numberCount.Count());
