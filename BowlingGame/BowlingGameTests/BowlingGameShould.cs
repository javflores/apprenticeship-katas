using Xunit;

namespace BowlingGameTests
{
    public class BowlingGameShould
    {
        [Theory]
        [InlineData("X|X|X|X|X|X|X|X|X|X||XX", 300)]
        [InlineData("9-|9-|9-|9-|9-|9-|9-|9-|9-|9-||", 90)]
        [InlineData("5/|5/|5/|5/|5/|5/|5/|5/|5/|5/||5", 150)]
        public void score_the_game(string game, int expectedScore)
        {
            var score = new BowlingGame.BowlingGame().Score(game);
            Assert.Equal(expectedScore, score);
        }
    }
}
