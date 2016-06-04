using System;
using System.Collections.Generic;
using GameOfLifeKata.Universe;

namespace GameOfLifeKata
{
    public class GeneratesSeedUniverse
    {
        private IPositionsGenerator _positionsGenerator;

        public GeneratesSeedUniverse(IPositionsGenerator positionsPositionsGenerator)
        {
            _positionsGenerator = positionsPositionsGenerator;
        }

        public virtual Universe.Universe Generate(int numberOfCells)
        {
            var cells = GenerateCells(numberOfCells);
            return new Universe.Universe(cells);
        }

        private Dictionary<int, Cell> GenerateCells(int numberOfCells)
        {
            var cells = new Dictionary<int, Cell>();
            for (int i = 0; i < numberOfCells; i++)
            {
                cells.Add(_positionsGenerator.Next(), new Cell());
            }

            return cells;
        }
    }
}