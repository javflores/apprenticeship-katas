using System.Collections.Generic;
using System.Linq;
using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public class WinningMoves
    {
        private readonly IList<IList<Position>> _winningMoves = new List<IList<Position>>
        {
            new List<Position> {new Position(0, 0), new Position(0, 1), new Position(0, 2)},
            new List<Position> {new Position(1, 0), new Position(1, 1), new Position(1, 2)},
            new List<Position> {new Position(2, 0), new Position(2, 1), new Position(2, 2)},
            new List<Position> {new Position(0, 0), new Position(1, 0), new Position(2, 0)},
            new List<Position> {new Position(0, 1), new Position(1, 1), new Position(2, 1)},
            new List<Position> {new Position(0, 2), new Position(1, 2), new Position(2, 2)},
            new List<Position> {new Position(0, 0), new Position(1, 1), new Position(2, 2)},
            new List<Position> {new Position(0, 2), new Position(1, 1), new Position(2, 0)}
        };

        public Player FindWinner(Positions positions)
        {
            return _winningMoves
                .Select(winningMove => positions.FindPlayerMatching(winningMove))
                .Where(player => !player.Equals(Player.NoPlayer))
                .DefaultIfEmpty(Player.NoPlayer)
                .FirstOrDefault();
        }
    }
}