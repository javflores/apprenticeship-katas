using System;
using System.Collections.Generic;
using System.Linq;

namespace BowlingGame
{
    public class Game
    {
        private readonly string[] MainGameDelimiter = { "", "||" };
        private const char FrameDelimiter = '|';

        public IEnumerable<Frame> Frames { get; }
        public string BonusBalls { get; }

        public Game(string gameOutput)
        {
            var parsedGame = gameOutput.Split(MainGameDelimiter, StringSplitOptions.None);
            Frames = parsedGame[0].Split(FrameDelimiter).Select(frame => new Frame(frame));
            BonusBalls = parsedGame[1];
        }

        public int Score()
        {
            return Frames
                .Select(frame => FrameScore(frame))
                .Aggregate((frameScore, nextFrameScore) => frameScore + nextFrameScore);
        }

        private int FrameScore(Frame frame)
        {
            if (frame.Balls.Contains("X"))
            {
                return 30;
            }
            var scores = frame.Balls.ToCharArray()
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