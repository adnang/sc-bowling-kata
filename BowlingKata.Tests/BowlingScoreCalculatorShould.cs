using FluentAssertions;
using NUnit.Framework;

namespace BowlingKata.Tests
{
    [TestFixture]
    public class BowlingScoreCalculatorShould
    {
        [Test]
        public void Return0_WhenCalculatingScore_GivenAllMisses()
        {
            var bowlingScoreCalculator = new BowlingScoreCalculator();
            var game = "--|--|--|--|--|--|--|--|--|--||--";

            var score = bowlingScoreCalculator.CalculateScore(game);

            score.Should().Be(0);
        }
    }
}
