namespace SeaChess
{
    public class Board
    {
        private string[,] board;

        private string winnerSymbol = "";

        public Board()
        {
            board = new string[3, 3];
            Fill();
        }

        private void Fill()
        {
            int count = 1;

            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {                   
                    board[row, col] = count.ToString();
                    count++;
                }
            }
        }

        public void Print()
        {

            Console.Clear();
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[2, 0], board[2, 1], board[2, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
        }

        public (bool, string) Change(string position ,string symbol)
        {
            var (row, col ) = GetPosition(position);           

            if (row == -1 && col == -1)
            {
                return (false, "Invalid position");
            }            

            board[row, col] = symbol;
            return (true, "Successful position");          

        }  
        
        public (bool, string) ChekForWinner()
        {
            var isWinningRightDiagonal = ChekRightDiagonal(0 , 0);
            var isWinningLeftDiagonal = ChekLeftDiagonal(0, 2);
            var isWinningVerticalsAndHorizontals = ChekVerticalsAndHorizontals();

            if (!isWinningLeftDiagonal && !isWinningRightDiagonal && !isWinningVerticalsAndHorizontals )
            {
                return (false, winnerSymbol);
            }

            return (true, winnerSymbol);
        }

        
        private bool ChekVerticalsAndHorizontals()
        {            

            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    winnerSymbol = board[i, 0];
                    return true;
                }

                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    winnerSymbol = board[0, i];
                    return true;
                }
            }

            return false;
        }

        private bool ChekRightDiagonal(int row, int col)
        {
            var isWinning = board[row, col] == board[row + 1, col + 1] && board[row + 1, col + 1] == board[row + 2, col + 2];

            if (isWinning)
            {
                winnerSymbol = board[row, col];
            }

            return isWinning;
        }

        private bool ChekLeftDiagonal(int row, int col)
        {
            var isWinning = board[row, col] == board[row + 1, col - 1] && board[row + 1, col - 1] == board[row + 2, col - 2];

            if (isWinning)
            {
                winnerSymbol = board[row, col];
            }

            return isWinning;
        }

        private (int, int) GetPosition(string position) 
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {

                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col] == position)
                    {
                        return (row, col);
                    }
                }                
            }

            return (-1, -1);
        }        
    }
}
