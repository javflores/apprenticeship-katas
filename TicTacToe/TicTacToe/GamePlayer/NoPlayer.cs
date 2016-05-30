namespace TicTacToe.GamePlayer
{
    public class NoPlayer : Player
    {
        public NoPlayer() : base(""){}

        public override string AsWinner()
        {
            return "In Progress";
        }
    }
}