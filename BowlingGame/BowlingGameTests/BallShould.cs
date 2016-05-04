using BowlingGame;
using Xunit;

namespace BowlingGameTests
{
    public class BallShould
    {
        [Theory]
        [InlineData('X', 30)]
        [InlineData('8', 8)]
        [InlineData('-', 0)]
        public void have_a_score(char ball, int expectedScore)
        {
            Assert.Equal(expectedScore, new Ball(ball).Score());
        }
    }
}