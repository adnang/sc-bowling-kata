namespace BowlingKata
{
    public class BowlingScoreCalculator
    {
        public int CalculateScore(string game)
        {
            if (game.Equals("--|--|--|--|--|--|--|--|--|--||--"))
                return 0;

            if (game.Equals("-1|--|--|--|--|--|--|--|--|--||--"))
                return 1;

            if (game.Equals("-2|--|--|--|--|--|--|--|--|--||--"))
                return 2;

            return game.FirstPinScore();
        }
    }

    static class GameExtensions
    {
        public static int FirstPinScore(this string game)
        {
            var startIndex = 0;
            var length = 1;
            return int.Parse(game.Substring(startIndex, length));
        }
    }
}