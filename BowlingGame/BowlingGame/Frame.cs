using System;
using System.Linq;

namespace BowlingGame
{
    public class Frame
    {
        private readonly string _frame;

        public Frame(string frame)
        {
            _frame = frame;
        }

        public string Balls { get; set; }

        public int Score()
        {
            if (_frame.Contains("X"))
            {
                return 30;
            }
            var scores = _frame.ToCharArray()
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