namespace TicTacToe.GamePlayer
{
    public class PlayerX : Player
    {
        public PlayerX() : base("X") {}

        public override string AsWinner()
        {
            return "X Win";
        }
    }
}