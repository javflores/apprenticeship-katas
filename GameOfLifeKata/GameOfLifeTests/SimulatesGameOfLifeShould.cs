using System.Collections.Generic;
using GameOfLifeKata;
using GameOfLifeKata.Universe;
using NSubstitute;
using Xunit;

namespace GameOfLifeTests
{
    public class SimulatesGameOfLifeShould
    {
        private readonly SimulatesGameOfLife _simulator;
        private readonly Universe _seedUniverse;

        public SimulatesGameOfLifeShould()
        {
            _seedUniverse = Substitute.For<Universe>(new Cells(new List<Cell>()));
            var generatesSeedUniverse = Substitute.For<GeneratesSeedUniverse>();
            generatesSeedUniverse.Generate().Returns(_seedUniverse);
            _simulator = new SimulatesGameOfLife(generatesSeedUniverse);
        }

        [Fact]
        public void start_universe_with_seed_universe()
        {
            Universe universe = _simulator.CurrentUniverse();

            Assert.Equal(_seedUniverse, universe);
        }

        [Fact]
        public void replaces_universe_with_current_universe_next_generation()
        {
            var nextGeneration = new Universe(new Cells(new List<Cell>()));
            _seedUniverse.NextGeneration().Returns(nextGeneration);

            _simulator.Simulate();

            Assert.Equal(nextGeneration, _simulator.CurrentUniverse());
        }
    }
}
