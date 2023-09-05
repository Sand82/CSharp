namespace SeaChess
{   
    public class Game
    {
        private Board? board;

        private Player? playerOne;

        private Player? playerTwo;

        public Game(Player playerOne, Player playerTwo)
        {
            this.board = new Board();
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
        }

        public void RunPipe()
        {                   
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

                if (boardCounter > 4)
                {
                    var (haveWinner, winnerString) = board.ChekForWinner();

                    if (haveWinner)
                    {
                        Console.Clear();
                        PrintWinner(winnerString);
                        IsHaveWinner = true;
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
            {               new ConfigurateGame();
            }
        }

        private void PrintWinner(string winnerString)
        {            
            board.Print();
            var player = playerOne.Symbol == winnerString ? playerOne : playerTwo;            
            PrintPlayersMessege($"We have winner {player.Name}!!!");
        }

        private bool PlayerTurn(Player player, string symbol)
        {
            PrintPlayersTurnMessage(player);
            var position = Console.ReadLine();
            var (isValidTurn, message) = board.Change(position, symbol);
            PrintPlayersMessege(message);

            return isValidTurn;
        }

        private void PrintPlayersTurnMessage(Player player)
        {
            Console.WriteLine($"It is a {player.Name} turn");
            Console.WriteLine("Chose position:");
        }

        private void PrintPlayersMessege(string message)
        {
            Console.WriteLine(message);
        }
    }
}
