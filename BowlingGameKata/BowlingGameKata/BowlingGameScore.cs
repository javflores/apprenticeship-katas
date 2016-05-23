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
            IList<Frame> frames = FindFrames(bowlerThrows);

            int score = 0;

            for (int frameIndex = 0; frameIndex < 10; frameIndex++)
            {
                var frame = frames[frameIndex];
                score += frame.Score(NextFrames(frames, frameIndex));
            }

            return score;
        }

        private IList<Frame> FindFrames(string bowlerThrows)
        {
            var frameSets = bowlerThrows.Split(new[] {BonusBallsSeparator}, StringSplitOptions.RemoveEmptyEntries);

            return MandatoryFrames(frameSets).Concat(BonusFrames(frameSets)).ToList();
        }

        private IList<Frame> MandatoryFrames(string[] frameSets)
        {
            return frameSets[0]
                .Split(FramesSeparator)
                .Select(frame => new Frame(frame))
                .ToList();
        }

        private IList<Frame> BonusFrames(string[] frameSets)
        {
            if (frameSets.Length > 1)
            {
                return frameSets[1]
                .Select(frame => new Frame(frame.ToString()))
                .ToList();
            }

            return new List<Frame>();
            
        }

        private List<INextFrame> NextFrames(IList<Frame> frames, int frameIndex)
        {
            return new List<INextFrame>(frames.Where(f => frames.IndexOf(f) > frameIndex));
        }
    }
}