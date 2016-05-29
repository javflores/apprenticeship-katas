namespace TicTacToe.GamePlayer
{
    public class PlayerO : Player
    {
        public PlayerO() : base("O") {}

        public override GameResult AsWinner()
        {
            return GameResult.OWin;
        }
    }
}