using FluentAssertions;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace BowlingKata.Tests
{
    [TestFixture]
    public class BowlingScoreCalculatorShould
    {
        private readonly BowlingScoreCalculator bowlingScoreCalculator = new BowlingScoreCalculator();

        [Test]
        public void Return0_WhenCalculatingScore_GivenAllMisses()
        {
            var game = "--|--|--|--|--|--|--|--|--|--||--";

            var score = bowlingScoreCalculator.CalculateScore(game);

            score.Should().Be(0);
        }

        [TestCase("1-|--|--|--|--|--|--|--|--|--||--", 1)]
        [TestCase("2-|--|--|--|--|--|--|--|--|--||--", 2)]
        [TestCase("3-|--|--|--|--|--|--|--|--|--||--", 3)]
        [TestCase("-1|--|--|--|--|--|--|--|--|--||--", 1)]
        [TestCase("-2|--|--|--|--|--|--|--|--|--||--", 2)]
        [TestCase("-3|--|--|--|--|--|--|--|--|--||--", 3)]
        public void ReturnExpected_WhenCalculatingScore_GivenNPinsHitOnOneThrowOfFirstFrame(string game, int expectedScore)
        {
            var score = bowlingScoreCalculator.CalculateScore(game);

            score.Should().Be(expectedScore);
        }

        [TestCase("--|1-|--|--|--|--|--|--|--|--||--", 1)]
        [TestCase("--|2-|--|--|--|--|--|--|--|--||--", 2)]
        [TestCase("--|-1|--|--|--|--|--|--|--|--||--", 1)]
        [TestCase("--|-2|--|--|--|--|--|--|--|--||--", 2)]
        public void ReturnExpected_WhenCalculatingScore_GivenNPinsHitOnOnePositionOfSecondFrame(string game, int expectedScore)
        {
            var score = bowlingScoreCalculator.CalculateScore(game);

            score.Should().Be(expectedScore);
        }

        [TestCase("--|--|1-|--|--|--|--|--|--|--||--", 1)]
        [TestCase("--|--|2-|--|--|--|--|--|--|--||--", 2)]
        [TestCase("--|--|-1|--|--|--|--|--|--|--||--", 1)]
        public void ReturnExpected_WhenCalculatingScore_GivenNPinsHitOnOnePositionOfThirdFrame(string game, int expectedScore)
        {
            var score = bowlingScoreCalculator.CalculateScore(game);

            score.Should().Be(expectedScore);
        }
    }
}
