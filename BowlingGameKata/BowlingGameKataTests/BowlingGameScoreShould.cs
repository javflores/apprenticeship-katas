using BowlingGameKata;
using Xunit;

namespace BowlingGameKataTests
{
    public class BowlingGameScoreShould
    {
        [Theory]
        [InlineData("X|X|X|X|X|X|X|X|X|X||XX", 300)]
        [InlineData("X|X|X|X|X|X|X|X|X|1-||", 91)]
        [InlineData("1-|1-|1-|1-|1-|1-|1-|1-|1-|1-||", 10)]
        [InlineData("2-|2-|2-|2-|2-|2-|2-|2-|2-|2-||", 20)]
        public void calculate_score(string gameResult, int expectedScore)
        {
            int score = new BowlingGameScore().Calculate(gameResult);

            Assert.Equal(expectedScore, score);
        }
    }
}
