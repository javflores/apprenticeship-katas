namespace BowlingGameKata
{
    public class Ball
    {
        private const char Strike = 'X';
        private const char Spare = '/';
        private const char Miss = '-';
        private readonly char _ball;

        public Ball(char ball)
        {
            _ball = ball;
        }

        public bool DidStrike()
        {
            return _ball == Strike;
        }

        public bool DidSpare()
        {
            return _ball == Spare;
        }

        public int Score()
        {
            if (_ball == Miss)
            {
                return 0;
            }

            if (_ball == Strike)
            {
                return 10;
            }

            return (int)char.GetNumericValue(_ball);
        }
    }
}