using System.Collections.Generic;
using System.Linq;

namespace GameOfLife
{
    public class Cell
    {
        private bool _alive;

        public Cell(bool alive)
        {
            _alive = alive;
        }

        public void ToNextGeneration(List<Cell> neighbours)
        {
            var aliveNeighbours = neighbours.Count(neighbour => neighbour.IsAlive());
            if (_alive)
            {
                _alive = aliveNeighbours == 2 || aliveNeighbours == 3;
            }

            else
            {
                _alive = aliveNeighbours == 3;
            }
            
        }

        public bool IsAlive()
        {
            return _alive;
        }
    }
}