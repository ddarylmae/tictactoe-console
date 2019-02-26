namespace TicTacToeConsole
{
    public class TicTacToe
    {
        public Board GameBoard;
        public char CurrentPlayer { get; set; }
        public char Winner { get; set; }
        public bool GameEnded { get; set; }

        public TicTacToe()
        {
            GameBoard = new Board();

            CurrentPlayer = 'X';
            Winner = ' ';
        }
    }
}