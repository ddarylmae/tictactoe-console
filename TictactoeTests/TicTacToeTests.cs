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
            
            game.MakeMove("1,1");
            
            Assert.Equal('O', game.CurrentPlayer);
        }
        
        [Fact]
        public void ShouldSwitchToPlayerXWhenCurrentPlayerIsO()
        {
            var game = new TicTacToe {CurrentPlayer = 'O'};

            game.MakeMove("1,1");
            
            Assert.Equal('X', game.CurrentPlayer);
        }

        [Fact]
        public void ShouldEndGameWhenUserHasQuit()
        {
            var game = new TicTacToe();

            game.MakeMove("q");
            
            Assert.True(game.GameEnded);
        }

        [Fact]
        public void ShouldNotEndGameWhenUserHasNotQuit()
        {
            var game = new TicTacToe();

            game.MakeMove("1,1");
            
            Assert.False(game.GameEnded);
        }
        
        [Fact]
        public void ShouldEndGameWhenEntireBoardIsFilled()
        {
            var game = new TicTacToe();

            game.MakeMove("1,1");
            game.MakeMove("1,2");
            game.MakeMove("1,3");
            
            game.MakeMove("2,1");
            game.MakeMove("2,2");
            game.MakeMove("2,3");
            
            game.MakeMove("3,1");
            game.MakeMove("3,2");
            game.MakeMove("3,3");
            
            Assert.True(game.GameEnded);
        }
        
        [Fact]
        public void ShouldNotEndGameWhenEntireBoardIsNotFilled()
        {
            var game = new TicTacToe();

            game.MakeMove("1,1");
            game.MakeMove("1,2");
            game.MakeMove("1,3");
            
            Assert.False(game.GameEnded);
        }
    }
    
}