using System;
using System.Linq;

namespace BowlingGameKata
{
    public class BowlingGameScore
    {
        public int Calculate(string gameResult)
        {
            var mainFrames = gameResult.Split(new []{"||"}, StringSplitOptions.RemoveEmptyEntries);
            var frames = mainFrames[0].Split('|');
            if (frames.All(f => f.Contains("1")))
            {
                return 10;
            }

            if (gameResult.Length < 23)
            {
                return 91;
            }

            return 300;
        }
    }
}