using System.Collections.Generic;
using System.Linq;

namespace GameOfLifeKata.Universe
{
    public class Universe
    {
        private readonly IDictionary<int, Cell> _cellsByLocation = new Dictionary<int, Cell>();

        public Universe(IDictionary<int, Cell> cellsByLocation)
        {
            _cellsByLocation = cellsByLocation;
        }

        public virtual Universe NextGeneration()
        {
            var nextGeneration = new Dictionary<int, Cell>();
            foreach (var cell in _cellsByLocation)
            {
                nextGeneration.Add(cell.Key, cell.Value.ToNextGeneration());
            }

            return new Universe(nextGeneration);
        }

        public bool Contains(Cell cell)
        {
            return _cellsByLocation.Any(postion => postion.Value == cell);
        }

        public Cell PickByLocation(int location)
        {
            return _cellsByLocation[location];
        }
    }
}