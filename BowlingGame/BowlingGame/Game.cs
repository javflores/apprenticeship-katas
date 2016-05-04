using System;
using System.Collections.Generic;

namespace BowlingGame
{
    public class Game
    {
        private readonly string[] MainGameDelimiter = { "", "||" };
        private const char FrameDelimiter = '|';

        public IEnumerable<string> Frames { get; }
        public string BonusBalls { get; }

        public Game(string gameOutput)
        {
            var parsedGame = gameOutput.Split(MainGameDelimiter, StringSplitOptions.None);
            Frames = parsedGame[0].Split(FrameDelimiter);
            BonusBalls = parsedGame[1];
        }
    }
}