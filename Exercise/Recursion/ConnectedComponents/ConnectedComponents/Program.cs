using System;
using System.Globalization;
using System.Xml.Linq;

namespace ConnectedComponents
{
    public class Program
    {
        private static List<int>[] graph;

        private static List<int> visited = new List<int>();

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            graph = new List<int>[n];

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(tokens))
                {
                    graph[i] = new List<int>();
                }                
                else
                {
                    var nums = tokens.Split(" ").Select(int.Parse).ToList();
                    graph[i] = nums;
                }
            }

            for (var node = 0; node < graph.Length; node++)
            {

                if (visited.Contains(node))
                {
                    continue;
                }

                var result = new List<int>();

                DFS(node, result);

                Console.WriteLine($"Connected component: {string.Join(" ", result)}");
            }
        }

        private static void DFS(int node, List<int> result)
        {
            if (visited.Contains(node)) 
            {
                return;
            }

            visited.Add(node);

            foreach (var child in graph[node])
            {
                DFS(child, result);
            }

            result.Add(node);
        }
    }
}