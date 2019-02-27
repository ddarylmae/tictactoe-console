namespace TicTacToeConsole
{
    public class TicTacToe
    {
        public GameBoard Board { get; set; }
        public char CurrentPlayer { get; set; }
        public char Winner { get; set; }
        public bool GameEnded { get; set; }

        public TicTacToe()
        {
            CurrentPlayer = 'X';
            Winner = ' ';
        }

        private void SwitchPlayer()
        {
            CurrentPlayer = CurrentPlayer == 'X' ? 'O' : 'X';
        }

        public bool MakeMove(string input)
        {
            SwitchPlayer();
            
            GameEnded = input.Equals("q");
            
            return false;
        }
    }
}