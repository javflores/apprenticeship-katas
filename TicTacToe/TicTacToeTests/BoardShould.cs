using TicTacToe.GameBoard;
using TicTacToe.GamePlayer;
using Xunit;

namespace TicTacToeTests
{
    public class BoardShould
    {
        private readonly Board _board = new Board();

        [Fact]
        public void returns_winner_when_player_has_filled_a_row()
        {
            Play(0, 0);
            Play(0, 1);
            Play(0, 2);

            Assert.Equal(new PlayerX(), _board.Winner());
        }

        [Fact]
        public void returns_winner_when_player_has_filled_in_a_column()
        {
            Play(0, 0);
            Play(1, 0);
            Play(2, 0);

            Assert.Equal(new PlayerX(), _board.Winner());
        }

        [Fact]
        public void returns_winner_when_has_filled_in_diagonal()
        {
            Play(0, 0);
            Play(1, 1);
            Play(2, 2);

            Assert.Equal(new PlayerX(), _board.Winner());
        }

        private void Play(int row, int column)
        {
            _board.Play(new Position(row, column), new PlayerX());
        }
    }
}