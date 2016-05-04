﻿using System.Linq;
using BowlingGame;
using Xunit;

namespace BowlingGameTests
{
    public class GameShould
    {
        [Theory]
        [InlineData("X|X|X|X|X|X|X|X|X|X||XX", new[] { "X", "X", "X", "X", "X", "X", "X", "X", "X", "X" })]
        [InlineData("9-|9-|9-|9-|9-|9-|9-|9-|9-|9-||", new[] { "9-", "9-", "9-", "9-", "9-", "9-", "9-", "9-", "9-", "9-" })]
        [InlineData("81|81|81|81|81|81|81|81|81|81||X1", new[] { "81", "81", "81", "81", "81", "81", "81", "81", "81", "81" })]
        public void contain_frames(string gameOutput, string[] expectedFrames)
        {
            var game = new Game(gameOutput);

            Assert.True(game.Frames.SequenceEqual(expectedFrames));
        }

        [Theory]
        [InlineData("X|X|X|X|X|X|X|X|X|X||XX", "XX")]
        [InlineData("9-|9-|9-|9-|9-|9-|9-|9-|9-|9-||", "")]
        public void contain_bonus_balls(string gameOutput, string expectedBonusBalls)
        {
            var game = new Game(gameOutput);

            Assert.Equal(expectedBonusBalls, game.BonusBalls);
        }

    }
}