using System;
using System.Linq;

namespace BowlingGame
{
    public class BowlingGame
    {
        public int Score(string game)
        {
            var parsedGame = game.Split(new string[]{"", "||"}, StringSplitOptions.None);
            var frames = parsedGame[0].Split('|');

            return frames
                .Select(frame => FrameScore(frame))
                .Aggregate((frameScore, nextFrameScore) => frameScore + nextFrameScore);
        }

        private int FrameScore(string frame)
        {
            if (frame.Contains("9"))
            {
                return 9;
            }
            else
            {
                return 10;
            }
        }
    }
}