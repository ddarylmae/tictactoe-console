using Xunit;
using TicTacToeConsole;

namespace TicTacToeTests
{
    public class PlayerTests
    {
        [Fact]
        public void ValidCoordinateInputShouldReturnTrue()
        {
            var player = new Player();
            
            Assert.True(player.ValidateCoordinates("1,1"));
        }
        
        [Fact]
        public void InvalidCoordinateInputShouldReturnFalse()
        {
            var player = new Player();
            
            Assert.False(player.ValidateCoordinates("1,4"));
        }

        [Fact]
        public void QLetterInputShouldReturnTrue()
        {
            var player = new Player();
            
            Assert.True(player.ValidateCoordinates("q"));
        }
    }
}