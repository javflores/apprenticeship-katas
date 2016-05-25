namespace TicTacToe
{
    public class Position
    {
        private readonly int _row;
        private readonly int _column;

        public Position(int row, int column)
        {
            _row = row;
            _column = column;
        }

        public override bool Equals(object another)
        {
            var anotherPosition = ((Position)another);
            return anotherPosition._row == _row && anotherPosition._column == _column;
        }
    }
}