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
        public void ShouldUpdateBoardCoordinate()
        {
            var board = new GameBoard();

            board.UpdateBoard(1, 1, 'X');
            
            Assert.Equal('X', board.Board[0,0]);
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