using System;

namespace SeaChess
{
    public class Program
    {

        
        public static void Main()
        {
           ConfigurateGame();
        }
        
        public static void ConfigurateGame()
        {
            var playerOne = new Player("X", "Player One");

            var playerTwo = new Player("O", "Player Two");

            var game = new Game(playerOne, playerTwo);

            game.Run();
        }
    }
}
