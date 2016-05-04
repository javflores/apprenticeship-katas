using System;
using System.Collections.Generic;
using System.Linq;

namespace BowlingGame
{
    public class Game
    {
        private readonly string[] MainGameDelimiter = { "", "||" };
        private const char FrameDelimiter = '|';

        private readonly IEnumerable<Frame> _frames;

        public Game(string gameOutput)
        {
            var parsedGame = gameOutput.Split(MainGameDelimiter, StringSplitOptions.None);
            _frames = parsedGame[0].Split(FrameDelimiter).Select(frame => new Frame(frame));
        }

        public int Score()
        {
            return _frames
                .Select(frame => frame.Score())
                .Aggregate((frameScore, nextFrameScore) => frameScore + nextFrameScore);
        }
    }
}