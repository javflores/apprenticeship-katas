using System.Collections.Generic;
using GameOfLifeKata.Universe;
using NSubstitute;
using Xunit;

namespace GameOfLifeTests
{
    public class UniverseShould
    {
        [Fact]
        public void return_next_generation_universe()
        {
            var cell = Substitute.For<Cell>(true);
            var nextGenerationCell = new Cell(true);
            cell.ToNextGeneration().Returns(nextGenerationCell);
            var cells = new List<Cell> {cell};

            Universe universe = new Universe(new Cells(cells));
            Universe nextUniverse = universe.NextGeneration();

            Assert.True(nextUniverse.Contains(nextGenerationCell));
        }
    }
}