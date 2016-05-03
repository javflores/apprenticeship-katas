using System;
using System.Collections.Generic;

namespace BowlingGame
{
    public class GameParser
    {
        private readonly string[] MainGameDelimiter = { "", "||" };
        private const char FrameDelimiter = '|';


        public Game Parse(string gameRepresentation)
        {
            var parsedGame = gameRepresentation.Split(MainGameDelimiter, StringSplitOptions.None);

            return new Game()
            {
                Frames = parsedGame[0].Split(FrameDelimiter),
                BonusBalls = parsedGame[1]
            };
        }
    }

    public class Game
    {
        public IEnumerable<string> Frames { get; set; }
        public string BonusBalls { get; set; }
    }
}