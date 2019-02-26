using Xunit;
using TicTacToeConsole;

namespace TicTacToeTests
{
    public class BoardTests
    {
        [Fact]
        public void ShouldInitialiseWithEmptyBoard()
        {
            var board = new Board();
            
            Assert.Equal(3, board.SomeBoard.GetLength(0));
            Assert.Equal(3, board.SomeBoard.GetLength(1));
        }
        
        [Fact]
        public void ShouldInitialiseWithDots()
        {
            var board = new Board();
            
            Assert.Equal('.', board.SomeBoard[0,0]);
            Assert.Equal('.', board.SomeBoard[0,1]);
            Assert.Equal('.', board.SomeBoard[0,2]);
            
            Assert.Equal('.', board.SomeBoard[1,0]);
            Assert.Equal('.', board.SomeBoard[1,1]);
            Assert.Equal('.', board.SomeBoard[1,2]);
            
            Assert.Equal('.', board.SomeBoard[2,0]);
            Assert.Equal('.', board.SomeBoard[2,1]);
            Assert.Equal('.', board.SomeBoard[2,2]);
        }

        [Fact]
        public void ShouldUpdateBoardCoordinate()
        {
            var board = new Board();

            board.UpdateBoard(1, 1, 'X');
            
            Assert.Equal('X', board.SomeBoard[0,0]);
        }
    }
}