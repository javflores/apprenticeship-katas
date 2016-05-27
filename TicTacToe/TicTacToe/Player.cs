namespace TicTacToe
{
    public class Player
    {
        private readonly string _player;

        public Player(string player)
        {
            _player = player;
        }

        public override bool Equals(object player)
        {
            return ((Player) player)._player == _player;
        }
    }
}