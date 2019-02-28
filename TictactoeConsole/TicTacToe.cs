using System;

namespace TicTacToeConsole
{
    public class TicTacToe
    {
        public GameBoard Board { get; set; }
        public char CurrentPlayer { get; set; }
        public char Winner { get; set; }
        public bool GameEnded { get; set; }

        public UserInputHandler InputHandler { get; set; }

        public TicTacToe()
        {
            InputHandler = new UserInputHandler();
            CurrentPlayer = 'X';
            Winner = ' ';
            
            DisplayWelcomeToGame();
        }

        private void SwitchPlayer()
        {
            CurrentPlayer = CurrentPlayer == 'X' ? 'O' : 'X';
        }

        public bool MakeMove(string input)
        {
            SwitchPlayer();
            
            GameEnded = InputHandler.HasUserQuit(input);
            
            return false;
        }

        public void DisplayWelcomeToGame()
        {
            Console.WriteLine("Welcome to Tic Tac Toe!\n\n");
            Console.WriteLine("Here's the current board:");
            
            Board.DisplayCurrentBoard();
        }
    }
}