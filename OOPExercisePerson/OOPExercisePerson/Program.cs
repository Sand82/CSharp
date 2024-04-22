using System;
using System.Threading.Channels;

namespace OOPExercisePerson
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numberOfLines = int.Parse(Console.ReadLine());

            var team = new Team("Sand");

            var persons = new List<Person>();

            for (int i = 0; i < numberOfLines; i++) 
            {             
               
                try
                {
                    var input = Console.ReadLine()?.Split();
                    var person = new Person(input[0].Trim(), input[1].Trim(), int.Parse(input[2].Trim()), decimal.Parse(input[3].Trim()));
                    persons.Add(person);
                }
                catch (ArgumentException ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }

            var percentage = decimal.Parse(Console.ReadLine());

            persons
                 .OrderBy(p => p.FirstName)
                 .ThenBy(p => p.Age)                 
                 .ToList()                 
                 .ForEach( p => p.IncreaseSalary(percentage));

            //persons.ForEach(p => Console.WriteLine(p.ToString()));

            foreach (var person in persons)
            {
                team.Add(person);
            }

            Console.WriteLine($"First team has {team.FirstTeamCount} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeamCount} players.");
        }
    }
}