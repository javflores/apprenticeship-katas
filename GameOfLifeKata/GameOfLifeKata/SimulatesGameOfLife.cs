namespace GameOfLifeKata
{
    public class SimulatesGameOfLife
    {
        private Universe _currentUniverse;

        public SimulatesGameOfLife(GeneratesSeedUniverse generatesSeedUniverse)
        {
            _currentUniverse = generatesSeedUniverse.Generate();
        }

        public void Simulate()
        {
            _currentUniverse = _currentUniverse.NextGeneration();
        }

        public Universe CurrentUniverse()
        {
            return _currentUniverse;
        }
    }
}