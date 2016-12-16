﻿using FluentAssertions;
using NUnit.Framework;

namespace BowlingKata.Tests
{
    [TestFixture]
    public class BowlingScoreCalculatorShould
    {
        [Test]
        public void Return0_WhenCalculatingScore_GivenAllMisses()
        {
            var score = new BowlingScoreCalculator().CalculateScore("--|--|--|--|--|--|--|--|--|--||--");
            score.Should().Be(0);
        }
    }
}
