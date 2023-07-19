using System;

namespace SeaChess
{
    public class Program
    {

        public static Board? board;
        public static void Main(string[] args)
        {
            board = new Board();

            var playerOne = new Player("O", "Player One");

            var playerTwo = new Player("X", "Player Two");

            var boardCounter = 1;

            while (boardCounter < 10) 
            {
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
                        var player = playerOne.Symbol == winnerString ? playerOne : playerTwo;

                        PrintPlayerMessege($"We have winner {player.Name}!!!");
                        board.Print();
                        break;
                    }
                }

                boardCounter++;                
            }            
        }

        public static bool PlayerTurn(Player player, string symbol)        
        {
            PrintPlayersTurn(player);
            var position = Console.ReadLine();
            var (isValidTurn, message) = board.ChangeBoard(position, symbol);
            PrintPlayerMessege(message);

            return isValidTurn;
        }

        public static void PrintPlayersTurn(Player player)
        {
            Console.WriteLine($"It is a {player.Name} turn");
            Console.WriteLine("Chose position:");
        }

        public static void PrintPlayerMessege(string message)
        {
            Console.WriteLine(message);
        }
    }
}
