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
        private readonly Universe _seed;

        public SimulatesGameOfLifeShould()
        {
            _seed = Substitute.For<Universe>(new Dictionary<int, Cell>());
            var generatesSeedUniverse = Substitute.For<GeneratesSeedUniverse>(new PositionsGenerator());
            generatesSeedUniverse.Generate(20).Returns(_seed);
            _simulator = new SimulatesGameOfLife(generatesSeedUniverse);
        }

        [Fact]
        public void start_universe_with_seed()
        {
            Universe universe = _simulator.CurrentUniverse();

            Assert.Equal(_seed, universe);
        }

        [Fact]
        public void replaces_universe_with_next_generation()
        {
            var nextGeneration = new Universe(new Dictionary<int, Cell>());
            _seed.NextGeneration().Returns(nextGeneration);

            _simulator.Simulate();

            Assert.Equal(nextGeneration, _simulator.CurrentUniverse());
        }
    }
}
