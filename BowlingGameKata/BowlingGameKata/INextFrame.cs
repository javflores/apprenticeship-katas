using System.Collections.Generic;

namespace BowlingGameKata
{
    public interface INextFrame
    {
        int SpareBonus();
        int StrikeBonus(IList<INextFrame> nextFrames);
    }
}