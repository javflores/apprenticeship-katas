using BowlingGameKata;
using Xunit;

namespace BowlingGameKataTests
{
    public class FrameShould
    {
        [Theory]
        [InlineData("12", new[] { '1', '1' }, 3)]
        [InlineData("1-", new[] { '1', '1' }, 1)]
        [InlineData("2-", new[] { '1', '1' }, 2)]
        [InlineData("-2", new[] { '1', '1' }, 2)]
        [InlineData("-2", new[] { 'X' }, 2)]
        [InlineData("1/", new [] { '1', '1' }, 11)]
        [InlineData("1/", new[] { '1', '-' }, 11)]
        [InlineData("1/", new[] { 'X' }, 20)]
        [InlineData("1/", new[] { '-', '1' }, 10)]
        [InlineData("1/", new[] { '-', '-' }, 10)]
        [InlineData("X", new[] { '1', '1' }, 12)]
        [InlineData("X", new[] { '-', '1' }, 11)]
        [InlineData("X", new[] { '1', '/' }, 20)]
        [InlineData("X", new[] { 'X' }, 20)]
        [InlineData("X", new char[] {}, 10)]
        public void have_a_score(string frame, char[] followingFrame, int expectedScore)
        {
            int frameScore = new Frame(frame).Score(followingFrame);

            Assert.Equal(expectedScore, frameScore);
        }
    }
}