namespace TicTacToe.GameBoard
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

        public override int GetHashCode()
        {
            return _row.GetHashCode() + _column.GetHashCode();
        }

        public override bool Equals(object another)
        {
            return ((Position)another)._column == _column && ((Position)another)._row == _row;
        }
    }
}