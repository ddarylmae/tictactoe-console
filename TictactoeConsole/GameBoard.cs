namespace TicTacToeConsole
{
    public class GameBoard
    {
        public char[,] Board;

        public GameBoard()
        {
            Board = new char[3,3];
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Board[row, column] = '.';
                }
            }
        }

        public void UpdateBoard(int row, int column, char currentPlayer)
        {
            Board[row-1, column-1] = currentPlayer;
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
    }
}