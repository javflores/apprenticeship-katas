using TicTacToe.GameBoard;
using TicTacToe.GamePlayer;
using Xunit;

namespace TicTacToeTests
{
    public class DiagonalRowsShould
    {
        [Fact]
        public void have_a_winner_in_first_diagonal()
        {
            var diagonalRows = new DiagonalRows();

            diagonalRows.Play(new Position(0, 0), new PlayerX());
            diagonalRows.Play(new Position(1, 1), new PlayerX());
            diagonalRows.Play(new Position(2, 2), new PlayerX());

            Assert.Equal(new PlayerX(), diagonalRows.Winner());
        }

        [Fact]
        public void have_a_winner_in_second_diagonal()
        {
            var diagonalRows = new DiagonalRows();

            diagonalRows.Play(new Position(0, 2), new PlayerX());
            diagonalRows.Play(new Position(1, 1), new PlayerX());
            diagonalRows.Play(new Position(2, 0), new PlayerX());

            Assert.Equal(new PlayerX(), diagonalRows.Winner());
        }
    }
}