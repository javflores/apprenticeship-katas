using TicTacToe;
using Xunit;

namespace TicTacToeTests
{
    public class BoardShould
    {
        [Fact]
        public void equal_another_board()
        {
            var board = new Board("---------");
            var another = new Board("---------");

            Assert.Equal(board, another);
        }
    }
}