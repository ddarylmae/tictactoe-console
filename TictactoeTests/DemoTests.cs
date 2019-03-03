using Xunit;

namespace TicTacToeTests
{
    public class DemoTests
    {
        [Fact]
        public void ShouldEndGameWhenInputIsQ()
        {
            var game = new Game();

            game.ReadInput("q");
            
            Assert.True(game.Ended);
        }

        [Fact]
        public void ShouldNotEndGameWhenInputIsInvalid()
        {
            var game = new Game();
            
            game.ReadInput("adslfkjds");
            
            Assert.False(game.Ended);
        }
    }

    public class Game
    {
        private Translator translator;

        public Game()
        {
            translator = new Translator();
        }

        public void ReadInput(string input)
        {
            if (translator.TranslateInput(input) == UserInput.Quit)
            {
                Ended = true;
            }
        }

        public bool Ended { get; set; }
    }

    internal class Translator
    {
        public UserInput TranslateInput(string input)
        {
            if (input == "q")
            {
                return UserInput.Quit;
            }

            return UserInput.Invalid;
        }
    }

    internal enum UserInput
    {
        Quit,
        Invalid = 0
    }
}