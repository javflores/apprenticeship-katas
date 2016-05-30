using System.Collections.Generic;
using System.Linq;
using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public class Positions
    {
        private readonly Dictionary<Position, Player> _positions = new Dictionary<Position, Player>
        {
            { new Position(0, 0), new NoPlayer()},
            { new Position(0, 1), new NoPlayer()},
            { new Position(0, 2), new NoPlayer()},
            { new Position(1, 0), new NoPlayer()},
            { new Position(1, 1), new NoPlayer()},
            { new Position(1, 2), new NoPlayer()},
            { new Position(2, 0), new NoPlayer()},
            { new Position(2, 1), new NoPlayer()},
            { new Position(2, 2), new NoPlayer()}
        };

        public void Play(Position position, Player player)
        {
            _positions[position] = player;
        }

        public bool AllFilledIn()
        {
            return _positions.All(position => !position.Value.Equals(new NoPlayer()));
        }

        public Player FindPlayerMatching(IList<Position> positionsPattern)
        {
            return _positions
                .GroupBy(position => position.Value)
                .Where(group => !group.Key.Equals(new NoPlayer()))
                .Where(x => x.Select(y => y.Key).SequenceEqual(positionsPattern))
                .Select(x => x.Key)
                .DefaultIfEmpty(new NoPlayer())
                .SingleOrDefault();
        }
    }
}