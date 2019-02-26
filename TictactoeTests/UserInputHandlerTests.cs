using Xunit;
using TicTacToeConsole;

namespace TicTacToeTests
{
    public class UserInputHandlerTests
    {
        [Fact]
        public void ValidCoordinateInputShouldReturnTrue()
        {
            var inputHandler = new UserInputHandler();
            
            Assert.True(inputHandler.ValidateInput("1,1"));
        }
        
        [Fact]
        public void InvalidCoordinateInputShouldReturnFalse()
        {
            var inputHandler = new UserInputHandler();
            
            Assert.False(inputHandler.ValidateInput("1,4"));
        }

        [Fact]
        public void QLetterInputShouldReturnTrue()
        {
            var inputHandler = new UserInputHandler();
            
            Assert.True(inputHandler.ValidateInput("q"));
        }

        [Fact]
        public void ShouldReturnTrueIfUserHasQuit()
        {
            var inputHandler = new UserInputHandler();
            
            Assert.True(inputHandler.HasUserQuit("q"));
        }
        
        [Fact]
        public void ShouldReturnFalseIfUserHasNotQuit()
        {
            var inputHandler = new UserInputHandler();
            
            Assert.False(inputHandler.HasUserQuit("1,1"));
        }
    }
}