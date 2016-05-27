using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class Rows
    {
        private List<Row> _rows;

        public Rows()
        {
            _rows = new List<Row>()
            {
                new Row(0),
                new Row(1),
                new Row(2)
            };
        }

        public void Add(Position position, Player player)
        {
            _rows.ForEach(row => row.Add(position, player));
        }

        public Player Winner()
        {
            Player winner = new NoPlayer();
            for (int row = 0; !winner.Equals(new NoPlayer()) || row < 3 ; row++)
            {
                winner = _rows[row].Winner();
                if (!winner.Equals(new NoPlayer()))
                {
                    return winner;
                }
            }

            return winner;
        }
    }
}