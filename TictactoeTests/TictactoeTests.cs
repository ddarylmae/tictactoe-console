using System;
using Xunit;

namespace TictactoeTests
{
    public class TictactoeTests
    {
        [Fact]
        public void ShouldInitialiseWithEmptyBoard()
        {
            var game = new Tictactoe();
            
            Assert.Equal(3, game.board.GetLength(0));
            Assert.Equal(3, game.board.GetLength(1));
        }

        [Fact]
        public void ShouldInitialiseWithDots()
        {
            var game = new Tictactoe();
            
            Assert.Equal('.', game.board[0,0]);
            Assert.Equal('.', game.board[0,1]);
            Assert.Equal('.', game.board[0,2]);
        }
    }
}