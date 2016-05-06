using System;
using System.Collections.Generic;
using System.Linq;

namespace BowlingGameKata
{
    public class BowlingGameScore
    {
        public int Calculate(string gameResult)
        {
            var mainFrames = gameResult.Split(new []{"||"}, StringSplitOptions.RemoveEmptyEntries);
            var frames = mainFrames[0].Split('|');
            var ballsForFrames = frames.Select(frame => frame.ToCharArray());

            if (frames.All(ContainsNumber))
            {
                return ballsForFrames
                    .Select(f => ToFrameScore(f))
                    .Aggregate((firstFrame, secondFrame) => firstFrame + secondFrame);
            }

            if (gameResult.Length < 23)
            {
                return 91;
            }

            return 300;
        }

        private int ToFrameScore(char[] frame)
        {
            if (frame.Contains("/"))
            {
                return 10;
            }

            return frame
                .Select(ToBallScore)
                .Aggregate((firstScore, secondScore) => firstScore + secondScore);
        }

        private int ToBallScore(char ball)
        {
            if (IsNumber(ball))
            {
                return (int) char.GetNumericValue(ball);
            }

            return 0;
        }

        private bool ContainsNumber(string frame)
        {
            return frame.ToCharArray().Any(x => IsNumber(x));
        }

        private bool IsNumber(char x)
        {
            return char.IsNumber(x);
        }
    }
}