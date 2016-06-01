using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLifeKata.Universe
{
    public class Universe
    {
        private readonly Cells _cells;

        public Universe(Cells cells)
        {
            _cells = cells;
        }

        public virtual Universe NextGeneration()
        {
            return new Universe(_cells.NextGeneration());
        }

        public bool Contains(Cell cell)
        {
            return _cells.Contains(cell);
        }
    }
}