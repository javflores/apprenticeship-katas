using TicTacToe.GameBoard;
using TicTacToe.GamePlayer;
using Xunit;

namespace TicTacToeTests
{
    public class VerticalRowsShould
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void have_a_winner(int column)
        {
            var verticalRows = new VerticalRows();

            verticalRows.Add(new Position(0, column), new PlayerX());
            verticalRows.Add(new Position(1, column), new PlayerX());
            verticalRows.Add(new Position(2, column), new PlayerX());

            Assert.Equal(new PlayerX(), verticalRows.Winner());
        }
    }
}