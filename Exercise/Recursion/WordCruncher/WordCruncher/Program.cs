﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCruncher
{
    public class Program
    {      
        public static Dictionary<int, List<string>> wordsByIndex = new Dictionary<int, List<string>>();

        public static Dictionary<string, int> wordsCount = new Dictionary<string, int>();

        private static LinkedList<string> usedWords = new LinkedList<string>();

        private static string? target;

        public static void Main(string[] args)
        {
            var words = Console.ReadLine()!.Split(", ");
            target = Console.ReadLine();

            foreach (var word in words)
            {
                var index = target!.IndexOf(word);

                if (index == -1)
                {
                    continue;
                }

                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word] += 1;
                    continue;
                }

                wordsCount[word] = 1;

                while(index != -1)
                {
                    if(!wordsByIndex.ContainsKey(index)) 
                    {
                        wordsByIndex[index] = new List<string>();
                    }

                    wordsByIndex[index].Add(word);

                    index = target.IndexOf(word, index + 1);
                }
            }
            
            GenSolutions(0);
        }

        private static void GenSolutions(int index)
        {
            if (index == target?.Length)
            {
                Console.WriteLine(string.Join(" ", usedWords));
                return;
            }

            if (!wordsByIndex.ContainsKey(index))
            {
                return;
            }

            foreach (var word in wordsByIndex[index])
            {
                if (wordsCount[word] == 0)
                {
                    continue;
                }

                wordsCount[word] -= 1;
                usedWords.AddLast(word);

                GenSolutions(index + word.Length);

                wordsCount[word] += 1;
                usedWords.RemoveLast();
            }            
        }
    }
}