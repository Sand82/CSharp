using System;

namespace TopologicalSorting
{
    public class Program
    {
        private static Dictionary<string, List<string>> graph = new Dictionary<string, List<string>>();

        private static Dictionary<string, int> edges;    

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            GetGraph(n);
            edges = GetEdges();
            var result = GetResult();

            if (edges.Count > 0)
            {
                Console.WriteLine($"Invalid topological sorting");
            }
            else
            {
                Console.WriteLine($"Topological sorting: {string.Join(", ", result)}");
            }                     
        }

        private static List<string> GetResult()
        {
            var result = new List<string>();

            while (true) 
            {
                if (graph.Count == 0)
                {
                    break;
                }

                var currentNode = edges.FirstOrDefault(x => x.Value == 0).Key;

                if (currentNode == null)
                {
                    break;
                }

                edges.Remove(currentNode);

                result.Add(currentNode);

                foreach (var child in graph[currentNode])
                {
                    edges[child] -= 1;
                }                
            }

            return result;
        }

        private static Dictionary<string, int> GetEdges()
        {
            var result = new Dictionary<string, int>();

            foreach (var node in graph)
            {
                var key = node.Key;
                var value = node.Value;

                if (!result.ContainsKey(key))
                {
                    result[key] = 0;
                }

                foreach (var child in value)
                {   
                    if (!result.ContainsKey(child))
                    {
                        result[child] = 1;
                    }
                    else
                    {
                        result[child] += 1;
                    }
                }
            }

            return result;
        }

        private static void GetGraph(int n)
        {
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine()!.Split("->", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

                var key = tokens[0];

                if (tokens.Length == 1)
                {
                    graph[key] = new List<string>();
                }
                else 
                {
                    var value = tokens[1].Trim().Split(", ").ToList();

                    graph[key] = value;
                }                
            }
        }
    }
}
