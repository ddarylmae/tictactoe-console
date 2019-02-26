namespace TicTacToeConsole
{
    public class TicTacToe
    {
        public char CurrentPlayer { get; set; }
        public char Winner { get; set; }
        public bool GameEnded { get; set; }

        public TicTacToe()
        {
            CurrentPlayer = 'X';
            Winner = ' ';
        }
    }
}