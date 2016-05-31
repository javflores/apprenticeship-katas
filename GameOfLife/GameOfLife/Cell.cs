using System.Collections.Generic;
using System.Linq;

namespace GameOfLife
{
    public class Cell
    {
        private bool _alive;
        private List<Cell> _neighbours;

        public Cell(bool alive)
        {
            _alive = alive;
        }

        public void ToNextGeneration(List<Cell> neighbours)
        {
            _neighbours = neighbours;

            _alive = Survival() || Reproduction();
        }

        public bool IsAlive()
        {
            return _alive;
        }

        private bool Reproduction()
        {
            var aliveNeighbours = _neighbours.Count(neighbour => neighbour.IsAlive());
            return !_alive && aliveNeighbours == 3;
        }

        private bool Survival()
        {
            var aliveNeighbours = _neighbours.Count(neighbour => neighbour.IsAlive());
            return _alive && (aliveNeighbours == 2 || aliveNeighbours == 3);
        }
    }
}