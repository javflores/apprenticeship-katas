using System.Collections.Generic;
using GameOfLife;
using Xunit;

namespace GameOfLifeTests
{
    public class CellShould
    {
        [Theory]
        [InlineData(0, true, false)]
        [InlineData(1, true, false)]
        [InlineData(2, true, true)]
        [InlineData(3, true, true)]
        [InlineData(4, true, false)]
        [InlineData(3, false, true)]
        [InlineData(2, false, false)]
        [InlineData(4, false, false)]
        public void be_transformed_to_next_generation(int numberOfLivingNeighbours, bool liveCell, bool expectedAliveNextGeneration)
        {
            var cell = new Cell(liveCell);
            var neighbours = ArrangeNeighbours(numberOfLivingNeighbours);

            cell.ToNextGeneration(neighbours);

            Assert.Equal(expectedAliveNextGeneration, cell.IsAlive());
        }

        private List<Cell> ArrangeNeighbours(int numberOfLivingNeighbours)
        {
            var neighbours = new List<Cell>();

            for (var neighbourIndex = 0; neighbourIndex < 8; neighbourIndex++)
            {
                var alive = neighbourIndex < numberOfLivingNeighbours;
                neighbours.Add(new Cell(alive));
            }
            return  neighbours;
        }
    }
}
