namespace TicTacToe.GamePlayer
{
    public class Players
    {
        private Player _current = Player.O;
        public Player Swap()
        {
            _current = _current.Equals(Player.O)
                ? Player.X
                : Player.O;

            return _current;
        }
    }
}