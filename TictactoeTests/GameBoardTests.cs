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

            var boardSize = board.GetBoardSize();

            Assert.Equal(9, boardSize);
        }
        
        [Fact]
        public void ShouldInitialiseWithDots()
        {
            var board = new GameBoard();
            
            Assert.Equal('.', board.GetElementAtCoordinate(1,1));
            Assert.Equal('.', board.GetElementAtCoordinate(1, 2));
            Assert.Equal('.', board.GetElementAtCoordinate(1,3));
            
            Assert.Equal('.', board.GetElementAtCoordinate(2,1));
            Assert.Equal('.', board.GetElementAtCoordinate(2,2));
            Assert.Equal('.', board.GetElementAtCoordinate(2,3));
            
            Assert.Equal('.', board.GetElementAtCoordinate(3,1));
            Assert.Equal('.', board.GetElementAtCoordinate(3,2));
            Assert.Equal('.', board.GetElementAtCoordinate(3,3));
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

            var hasUnmarkedCoordinate = board.HasUnmarkedCoordinate();
            
            Assert.True(hasUnmarkedCoordinate);
        }
        
        [Fact]
        public void ShouldReturnFalseWhenBoardHasNoUnmarkedCoordinate()
        {
            var board = new GameBoard();
            // Mock?
            for (int row = 1; row < 4; row++)
            {
                for (int column = 1; column < 4; column++)
                {
                    board.UpdateBoard(row, column, 'X');
                }
            }

            var hasUnmarkedCoordinate = board.HasUnmarkedCoordinate();
            
            Assert.False(hasUnmarkedCoordinate);
        }

        [Fact]
        public void ShouldUpdateBoardCoordinate()
        {
            var board = new GameBoard();

            board.UpdateBoard(1, 1, 'X');
            var actualElement = board.GetElementAtCoordinate(1, 1);

            Assert.Equal('X', actualElement);
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
            // Mock?
            board.UpdateBoard(1,1,'X');
            
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