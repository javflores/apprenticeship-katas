using System.Linq;
using BowlingGame;
using Xunit;

namespace BowlingGameTests
{
    public class GameShould
    {
        [Theory]
        [InlineData("X|X|X|X|X|X|X|X|X|X||XX", new[] { "X", "X", "X", "X", "X", "X", "X", "X", "X", "X" })]
        [InlineData("9-|9-|9-|9-|9-|9-|9-|9-|9-|9-||", new[] { "9-", "9-", "9-", "9-", "9-", "9-", "9-", "9-", "9-", "9-" })]
        [InlineData("81|81|81|81|81|81|81|81|81|81||X1", new[] { "81", "81", "81", "81", "81", "81", "81", "81", "81", "81" })]
        public void contain_frames(string gameOutput, string[] expectedFrames)
        {
            var game = new Game(gameOutput);

            Assert.True(game.Frames.SequenceEqual(expectedFrames));
        }

        [Theory]
        [InlineData("X|X|X|X|X|X|X|X|X|X||XX", "XX")]
        [InlineData("9-|9-|9-|9-|9-|9-|9-|9-|9-|9-||", "")]
        public void contain_bonus_balls(string gameOutput, string expectedBonusBalls)
        {
            var game = new Game(gameOutput);

            Assert.Equal(expectedBonusBalls, game.BonusBalls);
        }

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