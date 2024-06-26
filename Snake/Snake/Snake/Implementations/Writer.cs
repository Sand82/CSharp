﻿using Snake.Contracts;
using Snake.IOC.Attributes;

namespace Snake.Implementations
{
    public class Writer : IWriter
    {
        [Inject]
        public Writer()
        {
            Console.CursorVisible = false;
        }

        public void PrintInConsole(char symbol, int xPosition, int yPosition)
        {
            Console.SetCursorPosition(xPosition, yPosition);
            Console.Write(symbol);
        }

        public void SetCursorPosition(int left, int right)
        {
            Console.SetCursorPosition(left, right);
        }

        public void Write(char symbol)
        {
            Console.Write(symbol);
        }

        public void Write(string symbol)
        {
            Console.Write(symbol);
        }

        public void WriteInPosition(int xPosition, int yPosition, string message)
        {
            SetCursorPosition(xPosition, yPosition);
            Write(message);
        }

        public bool KeyAvailable()
        {
            return Console.KeyAvailable;
        }

        public ConsoleKey Key()
        {
            var info = Console.ReadKey(true);

            return info.Key;
        }
    }
}
