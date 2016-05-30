using System.Collections.Generic;
using System.Linq;
using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public class Rows
    {
        private readonly List<Row> _rows = new List<Row>()
        {
            new Row(new Position(0, 0), new Position(0, 1), new Position(0, 2)),
            new Row(new Position(1, 0), new Position(1, 1), new Position(1, 2)),
            new Row(new Position(2, 0), new Position(2, 1), new Position(2, 2)),
            new Row(new Position(0, 0), new Position(1, 0), new Position(2, 0)),
            new Row(new Position(0, 1), new Position(1, 1), new Position(2, 1)),
            new Row(new Position(0, 2), new Position(1, 2), new Position(2, 2)),
            new Row(new Position(0, 0), new Position(1, 1), new Position(2, 2)),
            new Row(new Position(0, 2), new Position(1, 1), new Position(2, 0))
        };

        public void Play(Position position, Player player)
        {
            _rows.ForEach(row => row.Play(position, player));
        }

        public bool AllFilledIn()
        {
            return _rows.All(row => row.AllFilledIn());
        }

        public Player FindWinner()
        {
            return _rows
                .Select(row => row.Winner())
                .Where(winner => !winner.Equals(Player.NoPlayer))
                .DefaultIfEmpty(Player.NoPlayer)
                .SingleOrDefault();
        }
    }
}