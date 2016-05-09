using System;

namespace BowlingGameKata
{
    public class BowlingGameScore
    {
        public int Calculate(string gameResult)
        {
            var mainFrames = gameResult
                .Split(new []{"||"}, StringSplitOptions.RemoveEmptyEntries);
            var frames = mainFrames[0].Split('|');

            int score = 0;
            for (var i = 0; i < frames.Length - 1; i++)
            {
                var frame = new Frame(frames[i]);
                score += frame.Score(frames[i + 1].ToCharArray());
            }

            score += new Frame(frames[frames.Length - 1]).Score(new char[] {});

            return score;
        }
    }
}