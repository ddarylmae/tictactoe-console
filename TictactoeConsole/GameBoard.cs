using System;

namespace TicTacToeConsole
{
    public class GameBoard
    {
        private char[,] Board;

        public char[] BoardOneD { get; set; }

        public GameBoard()
        {
            BoardOneD = new char[9];
            Board = new char[3,3];
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Board[row, column] = '.';
                }
            }
        }

        public bool UpdateBoard(int row, int column, char currentPlayer)
        {
            if (!IsCoordinateMarked(row, column))
            {
                Board[row-1, column-1] = currentPlayer;
                return true;
            }

            return false;
        }

        public bool IsWinningMove(char currentPlayer)
        {
            if (Board[0, 0] == currentPlayer && Board[0, 1] == currentPlayer && Board[0, 2] == currentPlayer ||
                Board[1, 0] == currentPlayer && Board[1, 1] == currentPlayer && Board[1, 2] == currentPlayer ||
                Board[2, 0] == currentPlayer && Board[2, 1] == currentPlayer && Board[2, 2] == currentPlayer ||
                Board[0, 0] == currentPlayer && Board[1, 0] == currentPlayer && Board[2, 0] == currentPlayer ||
                Board[0, 1] == currentPlayer && Board[1, 1] == currentPlayer && Board[2, 1] == currentPlayer ||
                Board[0, 2] == currentPlayer && Board[1, 2] == currentPlayer && Board[2, 2] == currentPlayer ||
                Board[0, 0] == currentPlayer && Board[1, 1] == currentPlayer && Board[2, 2] == currentPlayer ||
                Board[2, 0] == currentPlayer && Board[1, 1] == currentPlayer && Board[0, 2] == currentPlayer)
            {
                return true;
            }

            return false;
        }

        public bool HasUnmarkedCoordinate()
        {
            var boardHasUnsetCoordinate = false;
            
            // TODO refactor (stop loop when an unset element is found or reached end of array
            foreach (var element in Board)
            {
                boardHasUnsetCoordinate = element == '.';
            }

            return boardHasUnsetCoordinate;
        }

        public bool IsCoordinateMarked(int row, int column)
        {
            return GetElementAtCoordinate(row,column) != '.';
        }

        public char GetElementAtCoordinate(int row, int column)
        {
            return Board[row - 1, column - 1];
        }

        public int GetRowCount()
        {
            return Board.GetLength(0);
        }

        public int GetColumnCount()
        {
            return Board.GetLength(1);
        }

        public void DisplayCurrentBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.Write($"{Board[row, column]} ");
                }
                Console.Write("\n");
            }
        }

        public int GetBoardSize()
        {
            return BoardOneD.Length;
        }
    }
}