namespace TicTacToe
{
    public abstract class Player
    {
        private readonly string _player;

        protected Player(string player)
        {
            _player = player;
        }

        public override bool Equals(object player)
        {
            return ((Player) player)._player == _player;
        }

        public override int GetHashCode()
        {
            return _player.GetHashCode();
        }
    }
}