using System.Collections.Generic;
using System.Linq;
using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public class Positions
    {
        private readonly Dictionary<Position, Player> _positions = new Dictionary<Position, Player>
        {
            { new Position(0, 0), Player.NoPlayer},
            { new Position(0, 1), Player.NoPlayer},
            { new Position(0, 2), Player.NoPlayer},
            { new Position(1, 0), Player.NoPlayer},
            { new Position(1, 1), Player.NoPlayer},
            { new Position(1, 2), Player.NoPlayer},
            { new Position(2, 0), Player.NoPlayer},
            { new Position(2, 1), Player.NoPlayer},
            { new Position(2, 2), Player.NoPlayer}
        };

        public void Play(Position position, Player player)
        {
            _positions[position] = player;
        }

        public bool AllFilledIn()
        {
            return _positions.All(position => !position.Value.Equals(Player.NoPlayer));
        }

        public Player FindPlayerMatching(IList<Position> positionsPattern)
        {
            return _positions
                .GroupBy(position => position.Value)
                .Where(positionsByPlayer => !positionsByPlayer.Key.Equals(Player.NoPlayer))
                .Where(positionsByPlayer => PlayedPositionsMatches(positionsPattern, positionsByPlayer))
                .Select(player => player.Key)
                .DefaultIfEmpty(Player.NoPlayer)
                .SingleOrDefault();
        }

        private bool PlayedPositionsMatches(IList<Position> positionsPattern, IGrouping<Player, KeyValuePair<Position, Player>> positionsByPlayer)
        {
            return positionsByPlayer.Select(positions => positions.Key).SequenceEqual(positionsPattern);
        }
    }
}