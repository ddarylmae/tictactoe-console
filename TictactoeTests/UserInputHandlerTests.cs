using Xunit;
using TicTacToeConsole;

namespace TicTacToeTests
{
    public class UserInputHandlerTests
    {
        [Fact]
        public void ShouldReturnTrueWhenCoordinateInputIsValid()
        {
            var inputHandler = new UserInputHandler();
            
            Assert.True(inputHandler.ValidateInput("1,1"));
        }
        
        [Fact]
        public void ShouldReturnFalseWhenCoordinateInputIsInvalid()
        {
            var inputHandler = new UserInputHandler();
            
            Assert.False(inputHandler.ValidateInput("1,4"));
        }

        [Fact]
        public void ShouldReturnTrueWhenInputIsQ()
        {
            var inputHandler = new UserInputHandler();
            
            Assert.True(inputHandler.ValidateInput("q"));
        }

        [Fact]
        public void ShouldReturnFalseIfInvalidInput()
        {
            var inputHandler = new UserInputHandler();
            
            Assert.False(inputHandler.ValidateInput("aaa"));
        }

        [Fact]
        public void ShouldReturnTrueIfUserHasQuit()
        {
            var inputHandler = new UserInputHandler();

            var hasUserQuit = inputHandler.HasUserQuit("q");
            
            Assert.True(hasUserQuit);
        }
        
        [Fact]
        public void ShouldReturnFalseIfUserHasNotQuit()
        {
            var inputHandler = new UserInputHandler();

            var hasUserQuit = inputHandler.HasUserQuit("1,1,");
            
            Assert.False(hasUserQuit);
        }

        [Fact]
        public void ShouldReturnCoordinates()
        {
            var inputHandler = new UserInputHandler();

            var coordinates = inputHandler.GetCoordinatesFromInput("1,1");
            
            Assert.Equal(2, coordinates.Length);
        }
    }
}