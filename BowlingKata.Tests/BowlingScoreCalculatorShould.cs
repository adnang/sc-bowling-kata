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
        [TestCase("-1|--|--|--|--|--|--|--|--|--||--", 1)]
        [TestCase("-2|--|--|--|--|--|--|--|--|--||--", 2)]
        [TestCase("--|1-|--|--|--|--|--|--|--|--||--", 1)]
        [TestCase("--|2-|--|--|--|--|--|--|--|--||--", 2)]
        [TestCase("--|-1|--|--|--|--|--|--|--|--||--", 1)]
        [TestCase("--|-2|--|--|--|--|--|--|--|--||--", 2)]
        [TestCase("--|--|1-|--|--|--|--|--|--|--||--", 1)]
        [TestCase("--|--|2-|--|--|--|--|--|--|--||--", 2)]
        [TestCase("--|--|-1|--|--|--|--|--|--|--||--", 1)]
        [TestCase("--|--|-2|--|--|--|--|--|--|--||--", 2)]
        public void ReturnExpected_WhenCalculatingScore_GivenPinsHitOnOneThrowOfAFrame(string game, int expectedScore)
        {
            var score = bowlingScoreCalculator.CalculateScore(game);

            score.Should().Be(expectedScore);
        }

        [TestCase("11|--|--|--|--|--|--|--|--|--||--", 2)]
        [TestCase("23|--|--|--|--|--|--|--|--|--||--", 5)]
        public void ReturnSumOfThrows_WhenCalculatingScore_GivenPinsHitOnBothThrowsOfFirstFrame(string game, int expectedScore)
        {
            var score = bowlingScoreCalculator.CalculateScore(game);

            score.Should().Be(expectedScore);
        }

        [TestCase("--|23|--|--|--|--|--|--|--|--||--", 5)]
        [TestCase("--|45|--|--|--|--|--|--|--|--||--", 9)]
        public void ReturnSumOfThrows_WhenCalculatingScore_GivenPinsHitOnBothThrowsOfSecondFrame(string game, int expectedScore)
        {
            var score = bowlingScoreCalculator.CalculateScore(game);

            score.Should().Be(expectedScore);
        }

        [TestCase("1-|1-|--|--|--|--|--|--|--|--||--", 2)]
        [TestCase("13|-4|--|--|--|--|--|--|--|--||--", 8)]
        [TestCase("13|-2|2-|--|--|--|--|--|--|--||--", 8)]
        public void ReturnSumOfFrames_WhenCalculatingScore_GivenPinsHitOnThrowsInMultipleFrames(string game, int expectedScore)
        {
            var score = bowlingScoreCalculator.CalculateScore(game);

            score.Should().Be(expectedScore);
        }
    }
}
