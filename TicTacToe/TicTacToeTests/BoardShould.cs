using TicTacToe.GameBoard;
using TicTacToe.GamePlayer;
using Xunit;

namespace TicTacToeTests
{
    public class BoardShould
    {
        private readonly Board _board = new Board();

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void returns_winner_when_player_has_filled_a_row(int row)
        {
            FillInRow(row);

            Assert.Equal(new PlayerX(), _board.Winner());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void returns_winner_when_player_has_filled_in_a_column(int column)
        {
            FillInColumn(column);

            Assert.Equal(new PlayerX(), _board.Winner());
        }

        [Fact]
        public void returns_winner_when_has_filled_in_first_diagonal()
        {
            Play(0, 0);
            Play(1, 1);
            Play(2, 2);

            Assert.Equal(new PlayerX(), _board.Winner());
        }

        [Fact]
        public void returns_winner_when_has_filled_in_second_diagonal()
        {
            Play(0, 2);
            Play(1, 1);
            Play(2, 0);

            Assert.Equal(new PlayerX(), _board.Winner());
        }

        private void FillInRow(int row)
        {
            Play(row, 0);
            Play(row, 1);
            Play(row, 2);
        }

        private void FillInColumn(int column)
        {
            Play(0, column);
            Play(1, column);
            Play(2, column);
        }

        private void Play(int row, int column)
        {
            _board.Play(new Position(row, column), new PlayerX());
        }
    }
}