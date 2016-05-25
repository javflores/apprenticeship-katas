using TicTacToe;
using Xunit;

namespace TicTacToeTests
{
    public class TicTacToeServiceShould
    {
        [Theory]
        [InlineData(0, 0, "X--------")]
        [InlineData(0, 1, "-X-------")]
        public void return_board_with_first_played_position(int row, int column, string expectedBoard)
        {
            var position = new Position(row, column);
            Board board = new TicTacToeService().Play(position);

            var boardAfterPlay = new Board(expectedBoard);
            Assert.Equal(boardAfterPlay, board);
        }
    }
}
