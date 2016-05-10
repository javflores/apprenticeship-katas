using System.Collections.Generic;
using System.Linq;

namespace BowlingGameKata
{
    public class BowlingGameScore
    {
        private string _bowlerThrows;

        public int Calculate(string bowlerThrows)
        {
            _bowlerThrows = bowlerThrows;

            int score = 0;
            int frameIndex = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                if (IsStrike(frameIndex))
                {
                    score += 10 + StrikeBonus(frameIndex);
                    frameIndex += 2;
                }

                else if (IsSpare(frameIndex))
                {
                    score += 10 + SpareBonus(frameIndex);
                    frameIndex += 3;
                }

                else
                {
                    score += KnockedPins(frameIndex) + KnockedPins(frameIndex + 1);
                    frameIndex += 3;
                }
            }

            return score;
        }

        private bool IsStrike(int frameIndex)
        {
            return _bowlerThrows[frameIndex] == 'X';
        }

        private int StrikeBonus(int frameIndex)
        {
            var secondBonusBallIndex = frameIndex + 3;
            if (IsStrike(frameIndex + 2))
            {
                secondBonusBallIndex = frameIndex + 4;
            }

            return KnockedPins(frameIndex + 2) + KnockedPins(secondBonusBallIndex);
        }

        private bool IsSpare(int frameIndex)
        {
            return _bowlerThrows[frameIndex + 1] == '/';
        }

        private int SpareBonus(int frameIndex)
        {
            return KnockedPins(frameIndex + 3);
        }

        private int KnockedPins(int frameIndex)
        {
            if (_bowlerThrows[frameIndex] == '-')
            {
                return 0;
            }

            if (IsStrike(frameIndex))
            {
                return 10;
            }

            return (int)char.GetNumericValue(_bowlerThrows[frameIndex]);
        }
    }
}