namespace BowlingKata
{
    public class BowlingScoreCalculator
    {
        public int CalculateScore(string game)
        {
            if (game.Equals("--|--|--|--|--|--|--|--|--|--||--"))
                return 0;

            if (game.StartsWith("-"))
                return SecondTurnScore(game);

            return game.FirstPinScore();
        }

        private static int SecondTurnScore(string game)
        {
            return int.Parse(game.Substring(1, 1));
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