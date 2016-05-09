using System.Linq;

namespace BowlingGameKata
{
    public class Frame
    {
        private const char Strike = 'X';
        private const char Spare = '/';
        private readonly string _frameThrows;

        public Frame(string frameThrows)
        {
            _frameThrows = frameThrows;
        }

        public int Score(string nextFrameThrows)
        {
            if (_frameThrows.Contains(Strike))
            {
                return 10 + ScoreNextTwoBalls(nextFrameThrows);
            }

            if (_frameThrows.Contains(Spare))
            {
                return 10 + ScoreNextBall(nextFrameThrows);
            }

            return ScoreNextTwoBalls(_frameThrows);
        }

        private int ScoreNextTwoBalls(string nextFrameThrows)
        {
            if (nextFrameThrows == string.Empty)
            {
                return 0;
            }

            if (nextFrameThrows.Contains(Spare) || nextFrameThrows.Contains(Strike))
            {
                return 10;
            }

            return ScoreForPinsKnocked(nextFrameThrows[0]) + ScoreForPinsKnocked(nextFrameThrows[1]);
        }

        private int ScoreNextBall(string nextFrameThrows)
        {
            return ScoreForPinsKnocked(nextFrameThrows[0]);
        }

        private int ScoreForPinsKnocked(char pinsThrow)
        {
            if (char.IsNumber(pinsThrow))
            {
                return (int) char.GetNumericValue(pinsThrow);
            }

            if (pinsThrow == Strike)
            {
                return 10;
            }

            return 0;
        }
    }
}