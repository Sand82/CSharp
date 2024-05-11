using System;

namespace SourceRemovalAlgorithm
{
    public class Program
    {
        private static List<int>[] graph;
        private static bool[] visited;
        private static int[] perant;

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);
            var s = int.Parse(Console.ReadLine()!);

            graph = new List<int>[n + 1];
            visited = new bool[graph.Length];
            perant = new int[graph.Length];

            Array.Fill(perant, -1);

            for (int i = 0; i < graph.Length; i++)
            {
                graph[i] = new List<int>();
            }

            for (int i = 0; i < s; i++)
            {
                var edge = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                var firstNode = edge[0];
                var secondNode = edge[1];

                graph[firstNode].Add(secondNode);
                graph[secondNode].Add(firstNode);
            }

            var start = int.Parse(Console.ReadLine()!);
            var destination = int.Parse(Console.ReadLine()!);

            BFS(start, destination);
        }

        private static void BFS(int startNode, int destination)
        {
            var queue = new Queue<int>();

            queue.Enqueue(startNode);
            visited[startNode] = true;

            while (queue.Count > 0) 
            { 
                var node = queue.Dequeue();

                if (node == destination)
                {
                    var path = GetPath(destination);
                    Console.WriteLine($"Shortest path length is: {path.Count - 1}");
                    Console.WriteLine(string.Join(" ", path));
                    break;
                }

                foreach (var child in graph[node])
                {
                    if (!visited[child])
                    {
                        perant[child] = node;
                        visited[child] = true;
                        queue.Enqueue(child);
                    }                    
                }
            }
        }

        private static Stack<int> GetPath(int destination)
        {
            var path = new Stack<int>();

            var index = perant[destination];
            path.Push(destination);

            while (index != -1) 
            { 
                path.Push(index);
                index = perant[index];
            }

            return path;
        }
    }
}