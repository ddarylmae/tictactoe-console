namespace TicTacToeConsole
{
    public class TicTacToe
    {
        public char[,] Board = new char[3, 3];
        public char CurrentPlayer { get; set; }
        public char Winner { get; set; }
        public bool GameEnded { get; set; }

        public TicTacToe()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Board[row, column] = '.';
                }
            }

            CurrentPlayer = 'X';
            Winner = ' ';
        }
    }
}