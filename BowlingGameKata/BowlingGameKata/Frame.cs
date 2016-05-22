using System.Collections.Generic;

namespace BowlingGameKata
{
    public class Frame
    {
        private const string Strike = "X";
        private const string Spare = "/";
        public readonly string _frame;

        public Frame(string frame)
        {
            _frame = frame;
        }

        public int Score(IList<Frame> nextFrames)
        {
            if (_frame == Strike)
            {
                return 10 + StrikeBonus(nextFrames);
            }

            if (_frame.Contains(Spare))
            {
                return 10 + SpareBonus(nextFrames);
            }

            return Score();
        }

        private int StrikeBonus(IList<Frame> nextFrames)
        {
            var nextFrame = nextFrames[0];
            if (nextFrame.IsStrike())
            {
                return 10 + nextFrames[1].ScoreFirstBall();
            }

            return nextFrame.Score();
        }

        private int SpareBonus(IList<Frame> nextFrames)
        {
            return nextFrames[0].ScoreFirstBall();
        }

        public bool IsStrike()
        {
            return _frame.Equals(Strike);
        }

        private int Score()
        {
            return ScoreBall(0) + ScoreBall(1);
        }

        public int ScoreFirstBall()
        {
            return ScoreBall(0);
        }

        private int ScoreBall(int ballIndex)
        {
            if (_frame[ballIndex] == '-')
            {
                return 0;
            }

            if (_frame[ballIndex] == 'X')
            {
                return 10;
            }

            return (int)char.GetNumericValue(_frame[ballIndex]);
        }
    }
}