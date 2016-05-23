﻿using System.Collections.Generic;

namespace BowlingGameKata
{
    public class Frame : IFrame, INextFrame
    {
        private const string Strike = "X";
        private const string Spare = "/";
        public readonly string _frame;

        public Frame(string frame)
        {
            _frame = frame;
        }

        public int Score(IList<INextFrame> nextFrames)
        {
            if (_frame == Strike)
            {
                return 10 + nextFrames[0].StrikeBonus(nextFrames);
            }

            if (_frame.Contains(Spare))
            {
                return 10 + nextFrames[0].SpareBonus();
            }

            return ScoreBall(0) + ScoreBall(1);
        }

        int INextFrame.StrikeBonus(IList<INextFrame> nextFrames)
        {
            if (_frame != Strike)
            {
                return ScoreBall(0) + ScoreBall(1);
            }

            return 10 + nextFrames[1].SpareBonus();
        }

        int INextFrame.SpareBonus()
        {
            if (_frame != Strike)
            {
                return ScoreBall(0);
            }

            return 10;
        }

        private int ScoreBall(int ballIndex)
        {
            if (_frame[ballIndex] == '-')
            {
                return 0;
            }

            return (int)char.GetNumericValue(_frame[ballIndex]);
        }
    }
}