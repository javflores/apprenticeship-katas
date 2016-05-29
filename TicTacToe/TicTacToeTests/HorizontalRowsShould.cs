using TicTacToe.GameBoard;
using TicTacToe.GamePlayer;
using Xunit;

namespace TicTacToeTests
{
    public class HorizontalRowsShould
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void have_a_winner(int row)
        {
            var horizontalRows = new HorizontalRows();

            horizontalRows.Play(new Position(row, 0), new PlayerX());
            horizontalRows.Play(new Position(row, 1), new PlayerX());
            horizontalRows.Play(new Position(row, 2), new PlayerX());

            Assert.Equal(new PlayerX(), horizontalRows.Winner());
        }
    }
}