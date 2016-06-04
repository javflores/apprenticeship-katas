namespace GameOfLifeKata
{
    public class SimulatesGameOfLife
    {
        private Universe.Universe _universe;

        public SimulatesGameOfLife(GeneratesSeedUniverse generatesSeedUniverse)
        {
            _universe = generatesSeedUniverse.Generate(20);
        }

        public void Simulate()
        {
            _universe = _universe.NextGeneration();
        }

        public Universe.Universe CurrentUniverse()
        {
            return _universe;
        }
    }
}