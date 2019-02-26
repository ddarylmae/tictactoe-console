using Xunit;
using TicTacToeConsole;

namespace TicTacToeTests
{
    public class UserInputHandlerTests
    {
        [Fact]
        public void ValidCoordinateInputShouldReturnTrue()
        {
            var player = new UserInputHandler();
            
            Assert.True(player.ValidateCoordinates("1,1"));
        }
        
        [Fact]
        public void InvalidCoordinateInputShouldReturnFalse()
        {
            var player = new UserInputHandler();
            
            Assert.False(player.ValidateCoordinates("1,4"));
        }

        [Fact]
        public void QLetterInputShouldReturnTrue()
        {
            var player = new UserInputHandler();
            
            Assert.True(player.ValidateCoordinates("q"));
        }
    }
}