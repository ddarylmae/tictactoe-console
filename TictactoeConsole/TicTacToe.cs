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
            Board = new GameBoard();
            InputHandler = new UserInputHandler();
            CurrentPlayer = 'X';
            Winner = ' ';
            
//            DisplayWelcomeToGame();
        }

        private void SwitchPlayer()
        {
            CurrentPlayer = CurrentPlayer == 'X' ? 'O' : 'X';
        }

        public bool MakeMove(string input)
        {
            if (InputHandler.HasUserQuit(input))
            {
                GameEnded = true;
                return false;
            }

            var coordinates = InputHandler.GetCoordinatesFromInput(input);
            
            if (!Board.IsCoordinateMarked(coordinates[0], coordinates[1]))
            {
                Board.UpdateBoard(coordinates[0], coordinates[1], CurrentPlayer);
                SwitchPlayer();
                GameEnded = !Board.HasUnmarkedCoordinate();
                return true;
            }
            
            return false;
        }

        private void FillCoordinate(string input)
        {
            var something = InputHandler.ValidateInput(input);
//            Board.UpdateBoard()
        }

        public void DisplayWelcomeToGame()
        {
            Console.WriteLine("Welcome to Tic Tac Toe!\n\n");
            Console.WriteLine("Here's the current board:");
            
            Board.DisplayCurrentBoard();
        }
    }
}