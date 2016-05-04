using BowlingGame;
using Xunit;

namespace BowlingGameTests
{
    public class FrameShould
    {
        [Theory]
        [InlineData("X", 30)]
        [InlineData("9-", 9)]
        [InlineData("8-", 8)]
        [InlineData("81", 9)]
        public void have_a_score(string frame, int expectedScore)
        {
            Assert.Equal(expectedScore, new Frame(frame).Score());
        }
    }
}