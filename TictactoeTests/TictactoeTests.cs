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
            
            Assert.Equal(3, game.Board.GetLength(0));
            Assert.Equal(3, game.Board.GetLength(1));
        }

        [Fact]
        public void ShouldInitialiseWithDots()
        {
            var game = new Tictactoe();
            
            Assert.Equal('.', game.Board[0,0]);
            Assert.Equal('.', game.Board[0,1]);
            Assert.Equal('.', game.Board[0,2]);
            
            Assert.Equal('.', game.Board[1,0]);
            Assert.Equal('.', game.Board[1,1]);
            Assert.Equal('.', game.Board[1,2]);
            
            Assert.Equal('.', game.Board[2,0]);
            Assert.Equal('.', game.Board[2,1]);
            Assert.Equal('.', game.Board[2,2]);
        }

        [Fact]
        public void ShouldStartWithPlayerX()
        {
            var game = new Tictactoe();
            
            Assert.Equal('X', game.CurrentPlayer);
        }

        [Fact]
        public void ShouldInitialiseWithNoWinner()
        {
            var game = new Tictactoe();
            
            Assert.Equal(' ', game.Winner);
        }

        [Fact]
        public void ShouldInitialiseWithGameNotEnded()
        {
            var game = new Tictactoe();
            
            Assert.Equal(false, game.GameEnded);
        }
        
    }
    
}