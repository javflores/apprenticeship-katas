using System.Collections.Generic;
using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public class Columns
    {
        private List<Column> _columns;

        public Columns()
        {
            _columns = new List<Column>()
            {
                new Column(0),
                new Column(1),
                new Column(2)
            };
        }

        public void Add(Position position, Player player)
        {
            _columns.ForEach(column => column.Add(position, player));
        }

        public Player Winner()
        {
            Player winner = new NoPlayer();
            for (int column = 0; winner.Equals(new NoPlayer()) && column < 3; column++)
            {
                winner = _columns[column].Winner();
            }

            return winner;
        }
    }
}