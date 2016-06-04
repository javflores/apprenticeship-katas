using System;

namespace GameOfLifeKata
{
    public class PositionsGenerator : IPositionsGenerator
    {
        public int Next()
        {
            var randomGenerator = new Random();
            return randomGenerator.Next(-1000, 1000);
        }
    }
}