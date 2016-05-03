using Xunit;

namespace BowlingGameTests
{
    public class BowlingGameShould
    {
        [Theory]
        [InlineData("X|X|X|X|X|X|X|X|X|X||XX", 300)]
        [InlineData("9-|9-|9-|9-|9-|9-|9-|9-|9-|9-||", 90)]
        [InlineData("8-|8-|8-|8-|8-|8-|8-|8-|8-|8-||", 80)]
        [InlineData("81|81|81|81|81|81|81|81|81|81||", 90)]
        public void score_the_game(string game, int expectedScore)
        {
            var score = new BowlingGame.BowlingGame().Score(game);
            Assert.Equal(expectedScore, score);
        }
    }
}
