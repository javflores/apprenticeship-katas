using System.Collections.Generic;

namespace BowlingGameKata
{
    public interface IFrame
    {
        int Score(IList<INextFrame> nextFrames);
    }
}