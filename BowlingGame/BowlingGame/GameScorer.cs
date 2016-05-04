using System;
using System.Linq;

namespace BowlingGame
{
    public class GameScorer
    {
        public int Score(string gameOutput)
        {
            var game = new Game(gameOutput);

            return game
                .Frames
                .Select(frame => FrameScore(frame))
                .Aggregate((frameScore, nextFrameScore) => frameScore + nextFrameScore);
        }

        private int FrameScore(string frame)
        {
            if (frame.Contains("X"))
            {
                return 30;
            }
            var scores = frame.ToCharArray()
                .Select(ball => ToScore(ball))
                .ToList();

            return scores[0] + scores[1];
        }

        private int ToScore(char firstBall)
        {
            if (Char.IsNumber(firstBall))
            {
                return int.Parse(firstBall.ToString());
            }

            return 0;
        }
    }
}