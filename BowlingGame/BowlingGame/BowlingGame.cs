using System;
using System.Linq;

namespace BowlingGame
{
    public class BowlingGame
    {
        private readonly GameParser _gameParser;

        public BowlingGame(GameParser gameParser)
        {
            _gameParser = gameParser;
        }

        public int Score(string gameOutput)
        {
            var game = _gameParser.Parse(gameOutput);

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