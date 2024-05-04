using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SchoolTeams
{
    public class Program
    {       

        private static List<string> girlsResultCombinations = new List<string>();

        private static List<string> boysResultCombinations = new List<string>();

        public static void Main(string[] args)
        {
            var girls = Console.ReadLine()!.Split(", ").ToList();
            var boys = Console.ReadLine()!.Split(", ").ToList();
            var girlsCombination = new string[3];
            var boysCombinations = new string[2];

            GetCombinations(0, 0, girlsCombination, girls, girlsResultCombinations);
            GetCombinations(0, 0, boysCombinations, boys, boysResultCombinations);

            foreach (var girlsTeam in girlsResultCombinations)
            {
                foreach (var boysTeam in boysResultCombinations)
                {
                    Console.WriteLine($"{girlsTeam}, {boysTeam}");
                }
            }
        }

        private static void GetCombinations(int count, int start, string[] combinations, List<string> elements, List<string> finalResult)
        {
            if (count >= combinations.Count())
            {
                finalResult.Add(string.Join(", ", combinations));
                return;
            }

            for (int i = start; i < elements.Count; i++)
            {
                combinations[count] = elements[i];
                GetCombinations(count + 1, i + 1, combinations, elements, finalResult);
            }
        }
    }
}