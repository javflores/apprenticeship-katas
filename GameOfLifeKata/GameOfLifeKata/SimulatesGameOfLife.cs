namespace GameOfLifeKata
{
    public class SimulatesGameOfLife
    {
        private Universe _universe;

        public SimulatesGameOfLife(GeneratesSeedUniverse generatesSeedUniverse)
        {
            _universe = generatesSeedUniverse.Generate();
        }

        public void Simulate()
        {
            _universe = _universe.NextGeneration();
        }

        public Universe CurrentUniverse()
        {
            return _universe;
        }
    }
}