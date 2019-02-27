using Xunit;
using TicTacToeConsole;

namespace TicTacToeTests
{
    public class GameBoardTests
    {
        [Fact]
        public void ShouldInitialiseWithEmptyBoard()
        {
            var board = new GameBoard();
            
            Assert.Equal(3, board.Board.GetLength(0));
            Assert.Equal(3, board.Board.GetLength(1));
        }
        
        [Fact]
        public void ShouldInitialiseWithDots()
        {
            var board = new GameBoard();
            
            Assert.Equal('.', board.Board[0,0]);
            Assert.Equal('.', board.Board[0,1]);
            Assert.Equal('.', board.Board[0,2]);
            
            Assert.Equal('.', board.Board[1,0]);
            Assert.Equal('.', board.Board[1,1]);
            Assert.Equal('.', board.Board[1,2]);
            
            Assert.Equal('.', board.Board[2,0]);
            Assert.Equal('.', board.Board[2,1]);
            Assert.Equal('.', board.Board[2,2]);
        }

        [Fact]
        public void ShouldReturnElementAtCoordinate()
        {
            var board = new GameBoard();

            var actualElement = board.GetElementAtCoordinate(1, 1);
            
            Assert.Equal('.', actualElement);
        }

        [Fact]
        public void ShouldReturnTrueWhenBoardHasUnmarkedCoordinate()
        {
            var board = new GameBoard();

            var hasUnmarkedCoordinate = board.CheckHasUnmarkedCoordinate();
            
            Assert.True(hasUnmarkedCoordinate);
        }
        
        [Fact]
        public void ShouldReturnFalseWhenBoardHasNoUnmarkedCoordinate()
        {
            var board = new GameBoard();
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    board.Board[row, column] = 'X';
                }
            }

            var hasUnmarkedCoordinate = board.CheckHasUnmarkedCoordinate();
            
            Assert.False(hasUnmarkedCoordinate);
        }

        [Fact]
        public void ShouldUpdateBoardCoordinate()
        {
            var board = new GameBoard();

            board.UpdateBoard(1, 1, 'X');
            
            Assert.Equal('X', board.Board[0,0]);
        }

        [Fact]
        public void ShouldReturnTrueWhenUpdatingUnmarkedCoordinate()
        {
            var board = new GameBoard();
            
            var hasUpdatedBoard = board.UpdateBoard(1,1,'X');
            
            Assert.True(hasUpdatedBoard);
        }
        
        [Fact]
        public void ShouldReturnFalseWhenUpdatingMarkedCoordinate()
        {
            var board = new GameBoard();
            board.Board[0, 0] = 'X';
            
            var hasUpdatedBoard = board.UpdateBoard(1,1,'X');
            
            Assert.False(hasUpdatedBoard);
        }

        [Fact]
        public void ShouldReturnTrueWhenWinningMove()
        {
            var board = new GameBoard();
            var currentPlayer = 'X';
            
            board.UpdateBoard(1,1, currentPlayer);
            board.UpdateBoard(1,2, currentPlayer);
            board.UpdateBoard(1,3, currentPlayer);

            var isWinner = board.IsWinningMove(currentPlayer);
            
            Assert.True(isWinner);
        }

        [Fact]
        public void ShouldReturnFalseWhenNotWinningMove()
        {
            var board = new GameBoard();
            var currentPlayer = 'X';
            
            board.UpdateBoard(1,1, currentPlayer);

            var isWinner = board.IsWinningMove(currentPlayer);
            
            Assert.False(isWinner);
        }
    }
}