namespace TicTacToeConsole
{
    public class Board
    {
        public char[,] SomeBoard = new char[3,3];

        public Board()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    SomeBoard[row, column] = '.';
                }
            }
        }

        public void UpdateBoard(int row, int column, char currentPlayer)
        {
            SomeBoard[row-1, column-1] = currentPlayer;
        }
    }
}