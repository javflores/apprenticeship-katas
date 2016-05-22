using System;
using System.Collections.Generic;
using System.Linq;

namespace BowlingGameKata
{
    public class BowlingGameScore
    {
        private const string BonusBallsSeparator = "||";
        private const char FramesSeparator = '|';

        public int Calculate(string bowlerThrows)
        {
            IList<Frame> frames = ParseFrames(bowlerThrows);

            int score = 0;

            for (int frameIndex = 0; frameIndex < 10; frameIndex++)
            {
                var frame = frames[frameIndex];
                score += frame.Score(NextFrames(frames, frameIndex));
            }

            return score;
        }

        private IList<Frame> ParseFrames(string bowlerThrows)
        {
            var mandatoryFrames = bowlerThrows.Split(new[] {BonusBallsSeparator}, StringSplitOptions.RemoveEmptyEntries);

            return mandatoryFrames[0]
                .Split(FramesSeparator)
                .Select(frame => new Frame(frame))
                .ToList();
        }

        private List<Frame> NextFrames(IList<Frame> frames, int frameIndex)
        {
            return frames.Where(f => frames.IndexOf(f) > frameIndex).ToList();
        }
    }
}