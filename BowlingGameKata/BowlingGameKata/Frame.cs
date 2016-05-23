using System.Collections.Generic;
using System.Linq;

namespace BowlingGameKata
{
    public class Frame : IFrame, INextFrame
    {
        private const int FullFrameScore = 10;
        private readonly IList<Ball> _balls;

        public Frame(string frame)
        {
            _balls = frame
                .Select(ball => new Ball(ball))
                .ToList();
        }

        public int Score(IList<INextFrame> nextFrames)
        {
            if (_balls.Any(x => x.DidStrike()))
            {
                return FullFrameScore + nextFrames[0].StrikeBonus(nextFrames);
            }

            if (_balls.Any(x => x.DidSpare()))
            {
                return FullFrameScore + nextFrames[0].SpareBonus();
            }

            return _balls.Sum(ball => ball.Score());
        }

        int INextFrame.StrikeBonus(IList<INextFrame> nextFrames)
        {
            if (_balls.Count == 1)
            {
                return _balls.Single().Score() + nextFrames[1].SpareBonus();
            }

            if (_balls.Any(x => x.DidSpare()))
            {
                return FullFrameScore;
            }

            return _balls.Sum(ball => ball.Score());
        }

        int INextFrame.SpareBonus()
        {
            return _balls.First().Score();
        }
    }
}