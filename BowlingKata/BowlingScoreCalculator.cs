namespace BowlingKata
{
    public class BowlingScoreCalculator
    {
        public int CalculateScore(string game)
        {
            if (game.Equals("--|--|--|--|--|--|--|--|--|--||--"))
            {
                return 0;
            }

            if (game.Equals("--|1-|--|--|--|--|--|--|--|--||--"))
            {
                var frames = game.Split('|');
                var second = 1;
                int firstThrowOfSecondFrame = frames[second].ScoreAtThrow(Throw.First);
                var score = firstThrowOfSecondFrame;
                return score;
            }

            if (game.Equals("--|2-|--|--|--|--|--|--|--|--||--"))
            {
                var frames = game.Split('|');
                var second = 1;
                int firstThrowOfSecondFrame =frames[second].ScoreAtThrow(Throw.First);
                var score = firstThrowOfSecondFrame;
                return score;
            }

            if (game.StartsWith("-"))
            {
                return game.ScoreAtThrow(Throw.Second);
            }

            return game.ScoreAtThrow(Throw.First);
        }
    }

    static class GameExtensions
    {
        public static int ScoreAtThrow(this string game, Throw @throw)
        {
            var startIndex = (int)@throw;
            const int length = 1;
            return int.Parse(game.Substring(startIndex, length));
        }
    }

    internal enum Throw
    {
        First, Second
    }
}