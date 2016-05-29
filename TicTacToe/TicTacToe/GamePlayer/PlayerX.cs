namespace TicTacToe.GamePlayer
{
    public class PlayerX : Player
    {
        public PlayerX() : base("X") {}

        public override GameResult AsWinner()
        {
            return GameResult.XWin;
        }
    }
}