namespace SeaChess
{
    public class ConfigurateGame
    {
        private Player playerOne = new Player("X", "Player One");

        private Player playerTwo = new Player("O", "Player Two");

        private Game game;

        public ConfigurateGame()
        {
            this.game = new Game(playerOne, playerTwo);

            this.game.RunPipe();
        }
    }
}
