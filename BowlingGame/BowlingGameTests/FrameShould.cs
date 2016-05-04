using BowlingGame;
using Xunit;

namespace BowlingGameTests
{
    public class FrameShould
    {
        [Fact]
        public void contain_balls()
        {
            Assert.Equal("35", new Frame("35").Balls);
        }
    }
}