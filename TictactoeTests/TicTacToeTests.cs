using Xunit;
using TicTacToeConsole;

namespace TicTacToeTests
{
    public class TicTacToeTests
    {
        [Fact]
        public void ShouldStartWithPlayerX()
        {
            var game = new TicTacToe();
            
            Assert.Equal('X', game.CurrentPlayer);
        }

        [Fact]
        public void ShouldInitialiseWithNoWinner()
        {
            var game = new TicTacToe();
            
            Assert.Equal(' ', game.Winner);
        }

        [Fact]
        public void ShouldInitialiseWithGameNotEnded()
        {
            var game = new TicTacToe();
            
            Assert.False(game.GameEnded);
        }

        [Fact]
        public void ShouldSwitchToPlayerOWhenCurrentPlayerIsX()
        {
            var game = new TicTacToe {CurrentPlayer = 'X'};
            
            game.SwitchPlayer();
            
            Assert.Equal('O', game.CurrentPlayer);
        }
        
        [Fact]
        public void ShouldSwitchToPlayerXWhenCurrentPlayerIsO()
        {
            var game = new TicTacToe {CurrentPlayer = 'O'};
            
            game.SwitchPlayer();
            
            Assert.Equal('X', game.CurrentPlayer);
        }
        
        
    }
    
}