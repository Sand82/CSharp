using System;

namespace SeaChess
{
    public class Program
    {

        public static Board? board;
        public static void Main()
        {
            board = new Board();

            var playerOne = new Player("X", "Player One");

            var playerTwo = new Player("O", "Player Two");

            var boardCounter = 1;

            var IsHaveWinner = false;

            while (boardCounter < 10) 
            {
                Console.Clear();
                board.Print();

                if (boardCounter % 2 == 0)
                {
                    var isValidTurn = PlayerTurn(playerTwo, playerTwo.Symbol);

                    if (!isValidTurn)
                    {
                        continue;
                    }
                }
                else 
                {
                    var isValidTurn = PlayerTurn(playerOne, playerOne.Symbol);

                    if (!isValidTurn)
                    {
                        continue;
                    }
                };   
                
                if(boardCounter > 4)
                {
                    var (haveWinner, winnerString) = board.ChekForWinner();

                    if (haveWinner) 
                    {
                        Console.Clear();
                        board.Print();
                        var player = playerOne.Symbol == winnerString ? playerOne : playerTwo;
                        IsHaveWinner = true;
                        PrintPlayersMessege($"We have winner {player.Name}!!!");                        
                        break;
                    }
                }

                boardCounter++;                
            }

            if (!IsHaveWinner)
            {
                PrintPlayersMessege("DRAW! No one winning!");
            }

            PrintPlayersMessege("For resrart the game tape Yes");

            var restartGame = Console.ReadLine();

            if (restartGame.ToLower() == "yes") 
            {
                Main();
            }
        }

        public static bool PlayerTurn(Player player, string symbol)        
        {
            PrintPlayersTurnMessage(player);
            var position = Console.ReadLine();
            var (isValidTurn, message) = board.ChangeBoard(position, symbol);
            PrintPlayersMessege(message);

            return isValidTurn;
        }

        public static void PrintPlayersTurnMessage(Player player)
        {
            Console.WriteLine($"It is a {player.Name} turn");
            Console.WriteLine("Chose position:");
        }

        public static void PrintPlayersMessege(string message)
        {
            Console.WriteLine(message);
        }
    }
}
