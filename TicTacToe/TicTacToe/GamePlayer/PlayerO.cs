namespace TicTacToe.GamePlayer
{
    public class PlayerO : Player
    {
        public PlayerO() : base("O") {}

        public override string AsWinner()
        {
            return "O Win";
        }
    }
}