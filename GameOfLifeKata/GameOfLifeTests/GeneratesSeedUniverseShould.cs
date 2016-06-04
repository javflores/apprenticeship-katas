using GameOfLifeKata;
using GameOfLifeKata.Universe;
using NSubstitute;
using Xunit;

namespace GameOfLifeTests
{
    public class GeneratesSeedUniverseShould
    {
        [Fact]
        public void assign_random_location_to_generated_cells()
        {
            IPositionsGenerator positionsGenerator = Substitute.For<IPositionsGenerator>();
            var location = 0;
            positionsGenerator.Next().Returns(location);
            var generatesSeedUniverse = new GeneratesSeedUniverse(positionsGenerator);

            var seedUniverse = generatesSeedUniverse.Generate(1);

            Cell cell = seedUniverse.PickByLocation(location);
            Assert.NotNull(cell);
        }
    }
}