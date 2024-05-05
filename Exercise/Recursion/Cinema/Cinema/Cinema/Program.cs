using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Cinema
{
    public class Program
    {
        private static List<string>? rotationPeoples;

        private static string[]? staticPeoples;

        private static bool[]? positions;

        static void Main(string[] args)
        {
            rotationPeoples = Console.ReadLine()!.Split(", ").ToList();

            positions = new bool[rotationPeoples.Count];

            staticPeoples = new string [rotationPeoples.Count];

            string tokens;

            while ((tokens = Console.ReadLine()!) != "generate")
            {
                var staticPerson = tokens.Split(" - ");

                var name = staticPerson[0];
                var index = int.Parse(staticPerson[1]) - 1;

                rotationPeoples.Remove(name);
                staticPeoples[index] = name;
                positions[index] = true;                
            }

            GetRotation(0);
        }

        private static void GetRotation(int index)
        {
            if (index >= rotationPeoples!.Count)
            {
                PrintResult();
                return;
            }

            GetRotation(index + 1);

            for (int i = index + 1; i < rotationPeoples.Count; i++)
            {
                Swap(index, i);
                GetRotation(index + 1);
                Swap(index, i);
            }
        }

        private static void PrintResult()
        {
            
            var rotationCount = 0;           

            for (int i = 0; i < staticPeoples!.Length; i++)
            {
                if (positions![i] == false)
                {
                    staticPeoples[i] = rotationPeoples![rotationCount];
                    rotationCount++;
                }                
            }

            Console.WriteLine(string.Join(" ", staticPeoples));
        }

        private static void Swap(int first, int second)
        {
            var temp = rotationPeoples![first];
            rotationPeoples[first] = rotationPeoples[second];
            rotationPeoples[second] = temp;
        }
    }
}