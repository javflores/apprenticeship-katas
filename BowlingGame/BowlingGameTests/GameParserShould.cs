using System.Collections;
using System.Linq;
using BowlingGame;
using Xunit;

namespace BowlingGameTests
{
    public class GameParserShould
    {
        [Theory]
        [InlineData("X|X|X|X|X|X|X|X|X|X||XX", new[] { "X", "X", "X", "X", "X", "X", "X", "X", "X", "X" })]
        [InlineData("9-|9-|9-|9-|9-|9-|9-|9-|9-|9-||", new[] { "9-", "9-", "9-", "9-", "9-", "9-", "9-", "9-", "9-", "9-" })]
        [InlineData("81|81|81|81|81|81|81|81|81|81||X1", new[] { "81", "81", "81", "81", "81", "81", "81", "81", "81", "81" })]
        public void find_frames(string gameOutput, string[] expectedFrames)
        {
            var parser = new GameParser();

            var parseGame = parser.Parse(gameOutput);

            Assert.True(parseGame.Frames.SequenceEqual(expectedFrames));
        }

        [Theory]
        [InlineData("X|X|X|X|X|X|X|X|X|X||XX", "XX")]
        [InlineData("9-|9-|9-|9-|9-|9-|9-|9-|9-|9-||", "")]
        public void find_bonus_balls(string gameOutput, string expectedBonusBalls)
        {
            var parser = new GameParser();

            var parseGame = parser.Parse(gameOutput);

            Assert.Equal(expectedBonusBalls, parseGame.BonusBalls);
        }

    }
}