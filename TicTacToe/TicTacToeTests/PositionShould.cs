using TicTacToe;
using Xunit;

namespace TicTacToeTests
{
    public class PositionShould
    {
        [Fact]
        public void equals_to_another_position()
        {
            var position = new Position(0, 0);
            var anotherPosition = new Position(0, 0);

            Assert.Equal(position, anotherPosition);
        }
    }
}