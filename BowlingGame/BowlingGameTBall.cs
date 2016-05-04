namespace BowlingGame
{
    public class Ball
    {
        private readonly char _ball;

        public Ball(char ball)
        {
            _ball = ball;
        }

        public int Score()
        {
            if (_ball.Equals('X'))
            {
                return 30;
            }

            if (char.IsNumber(_ball))
            {
                return int.Parse(_ball.ToString());
            }

            return 0;
        }
    }
}