using System.Collections.Generic;
using System.Linq;

namespace GameOfLifeKata.Universe
{
    public class Cells
    {
        private readonly IEnumerable<Cell> _cells;
        public Cells(IEnumerable<Cell> cells)
        {
            _cells = cells;
        }

        public Cells NextGeneration()
        {
            return new Cells(_cells.Select(cell => cell.ToNextGeneration()));
        }

        public bool Contains(Cell cell)
        {
            return _cells.Contains(cell);
        }
    }
}