using System;

namespace BowlingGameKata
{
    public class BowlingGameScore
    {
        public int Calculate(string bowlerThrows)
        {
            var throws = bowlerThrows
                .Split(new []{"||"}, StringSplitOptions.RemoveEmptyEntries);

            var mandatoryThrows = throws[0].Split('|');

            int score = 0;
            for (var frameIndex = 0; frameIndex < mandatoryThrows.Length - 1; frameIndex++)
            {
                score += new Frame(mandatoryThrows[frameIndex])
                    .Score(mandatoryThrows[frameIndex + 1]);
            }

            score += new Frame(mandatoryThrows[mandatoryThrows.Length - 1]).Score("");

            return score;
        }
    }
}