namespace TicTacToe.GamePlayer
{
    public class NoPlayer : Player
    {
        public NoPlayer() : base(""){}

        public override GameResult AsWinner()
        {
            return GameResult.InProgress;
        }
    }
}