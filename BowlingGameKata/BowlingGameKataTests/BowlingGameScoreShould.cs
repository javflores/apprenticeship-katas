using BowlingGameKata;
using Xunit;

namespace BowlingGameKataTests
{
    public class BowlingGameScoreShould
    {
        [Theory]
        [InlineData("--|--|--|--|--|--|--|--|--|--||", 0)]
        [InlineData("11|11|11|11|11|11|11|11|11|11||", 20)]
        [InlineData("1/|11|11|11|11|11|11|11|11|11||", 29)]
        [InlineData("1/|21|11|11|11|11|11|11|11|11||", 31)]
        [InlineData("1/|21|11|11|11|11|11|--|11|11||", 29)]
        [InlineData("1/|X|11|11|11|11|11|--|11|11||", 46)]
        [InlineData("X|21|11|11|11|11|11|--|11|11||", 30)]
        [InlineData("X|X|11|11|11|11|11|--|11|11||", 47)]
        [InlineData("X|X|X|11|11|11|11|--|11|11||", 75)]
        [InlineData("X|X|X|X|X|X|X|X|X|11||", 245)]
        public void calculate_score(string bowlerThrows, int expectedScore)
        {
            int score = new BowlingGameScore().Calculate(bowlerThrows);

            Assert.Equal(expectedScore, score);
        }
    }
}
