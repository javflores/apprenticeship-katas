using GameOfLifeKata;
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
            _seedUniverse = Substitute.For<Universe>();
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
        public void gets_next_generation_of_universe()
        {
            var nextGeneration = new Universe();
            _seedUniverse.NextGeneration().Returns(nextGeneration);

            _simulator.Simulate();

            Assert.Equal(nextGeneration, _simulator.CurrentUniverse());
        }
    }
}
