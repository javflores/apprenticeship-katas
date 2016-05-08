using System.Collections.Generic;
using System.Linq;

namespace BowlingGameKata
{
    public class Frame
    {
        private const char Strike = 'X';
        private const char Spare = '/';
        private readonly IList<char> _pinsKnocked;

        public Frame(string frame)
        {
            _pinsKnocked = frame.ToCharArray();
        }

        public int Score(char[] pinsKnockedNextFrame)
        {
            if (_pinsKnocked.Contains(Spare))
            {
                return 10 + Score(pinsKnockedNextFrame[0]);
            }

            if (_pinsKnocked.Contains(Strike))
            {
                return 10 + NextFrameScore(pinsKnockedNextFrame);
            }

            return _pinsKnocked
                .Select(ball => Score(ball))
                .Aggregate((firstScore, secondScore) => firstScore + secondScore);
        }

        private int NextFrameScore(char[] pinsKnockedNextFrame)
        {
            if (pinsKnockedNextFrame.Contains(Spare) || pinsKnockedNextFrame.Contains(Strike))
            {
                return 10;
            }

            return Score(pinsKnockedNextFrame[0]) + Score(pinsKnockedNextFrame[1]);
        }

        private static int Score(char ball)
        {
            if (char.IsNumber(ball))
            {
                return (int) char.GetNumericValue(ball);
            }

            if (ball == Strike)
            {
                return 10;
            }

            return 0;
        }
    }
}