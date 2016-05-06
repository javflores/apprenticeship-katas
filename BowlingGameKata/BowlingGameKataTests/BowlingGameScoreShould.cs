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
        [InlineData("-2|-1|2-|2-|2-|2-|-1|2-|2-|2-||", 18)]
        [InlineData("52|51|26|22|23|24|41|25|21|23||", 56)]
        [InlineData("1/|11|11|11|11|11|11|11|11|11||", 29)]
        public void calculate_score(string gameResult, int expectedScore)
        {
            int score = new BowlingGameScore().Calculate(gameResult);

            Assert.Equal(expectedScore, score);
        }
    }
}
