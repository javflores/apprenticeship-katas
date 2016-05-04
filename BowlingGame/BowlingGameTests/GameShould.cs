using BowlingGame;
using Xunit;

namespace BowlingGameTests
{
    public class GameShould
    {
        [Theory]
        [InlineData("X|X|X|X|X|X|X|X|X|X||XX", 300)]
        [InlineData("9-|9-|9-|9-|9-|9-|9-|9-|9-|9-||", 90)]
        [InlineData("8-|8-|8-|8-|8-|8-|8-|8-|8-|8-||", 80)]
        [InlineData("81|81|81|81|81|81|81|81|81|81||", 90)]
        public void have_a_score(string gameOutput, int expectedScore)
        {
            var game = new Game(gameOutput);

            Assert.Equal(expectedScore, game.Score());
        }
    }
}