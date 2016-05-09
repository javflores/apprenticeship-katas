using BowlingGameKata;
using Xunit;

namespace BowlingGameKataTests
{
    public class FrameShould
    {
        [Theory]
        [InlineData("12", "11", 3)]
        [InlineData("1-", "11", 1)]
        [InlineData("2-", "11", 2)]
        [InlineData("-2", "11", 2)]
        [InlineData("-2", "X", 2)]
        [InlineData("1/", "11", 11)]
        [InlineData("1/", "1-", 11)]
        [InlineData("1/", "X", 20)]
        [InlineData("1/", "-1", 10)]
        [InlineData("1/", "--", 10)]
        [InlineData("X", "11", 12)]
        [InlineData("X", "-1", 11)]
        [InlineData("X", "1/", 20)]
        [InlineData("X", "X", 20)]
        [InlineData("X", "", 10)]
        public void have_a_score(string frameThrows, string nextFrameThrows, int expectedScore)
        {
            int frameScore = new Frame(frameThrows).Score(nextFrameThrows);

            Assert.Equal(expectedScore, frameScore);
        }
    }
}