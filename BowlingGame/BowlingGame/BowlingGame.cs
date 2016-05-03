using System;
using System.Linq;

namespace BowlingGame
{
    public class BowlingGame
    {
        private readonly string[] MainGameDelimiter = { "", "||" };
        private const char FrameDelimiter = '|';

        public int Score(string game)
        {
            var frames = FindFrames(game);

            return frames
                .Select(frame => FrameScore(frame))
                .Aggregate((frameScore, nextFrameScore) => frameScore + nextFrameScore);
        }

        private string[] FindFrames(string game)
        {
            var parsedGame = game.Split(MainGameDelimiter, StringSplitOptions.None);
            return parsedGame[0].Split(FrameDelimiter);
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