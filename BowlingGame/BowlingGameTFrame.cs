using System.Collections.Generic;

namespace BowlingGame
{
    public class Frame
    {
        private readonly string _frame;

        public Frame(string frame)
        {
            Balls = frame;
        }

        public string Balls { get; set; }
    }
}