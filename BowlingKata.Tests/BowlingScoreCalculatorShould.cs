using FluentAssertions;
using NUnit.Framework;

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

        [Test]
        public void Return1_WhenCalculatingScore_Given1PinHitInFirstFrame()
        {
            var game = "1-|--|--|--|--|--|--|--|--|--||--";

            int score = bowlingScoreCalculator.CalculateScore(game);

            score.Should().Be(1);
        }

        [Test]
        public void Return2_WhenCalculatingScore_Given2PinHitInFirstFrame()
        {
            var game = "2-|--|--|--|--|--|--|--|--|--||--";

            var score = bowlingScoreCalculator.CalculateScore(game);

            score.Should().Be(2);
        }
    }
}
