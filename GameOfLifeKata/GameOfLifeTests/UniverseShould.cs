using System.Collections.Generic;
using GameOfLifeKata.Universe;
using NSubstitute;
using Xunit;

namespace GameOfLifeTests
{
    public class UniverseShould
    {
        [Fact]
        public void produce_a_next_generation()
        {
            var cell = Substitute.For<Cell>(true);
            var nextGenerationCell = Substitute.For<Cell>(true);
            cell.ToNextGeneration().Returns(nextGenerationCell);
            var cells = new Dictionary<int, Cell> {{0, cell}};

            Universe universe = new Universe(cells);
            Universe nextUniverse = universe.NextGeneration();

            Assert.True(nextUniverse.Contains(nextGenerationCell));
        }
    }
}