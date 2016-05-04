using System.Collections.Generic;
using System.Linq;

namespace BowlingGame
{
    public class Frame
    {
        private readonly IList<Ball> _balls = new List<Ball>();

        public Frame(string frame)
        {
            InitializeBalls(frame);
        }

        private void InitializeBalls(string frame)
        {
            var balls = frame.ToCharArray().ToList();

            balls.ForEach(ball => _balls.Add(new Ball(ball)));
        }

        public int Score()
        {
            return _balls
                .Select(ball => ball.Score())
                .Aggregate((firstScore, secondScore) => firstScore + secondScore);
        }
    }
}