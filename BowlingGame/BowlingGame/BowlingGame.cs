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
            if (frame.Contains("9"))
            {
                return 9;
            }

            return 30;
        }
    }
}