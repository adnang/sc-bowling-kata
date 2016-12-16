namespace BowlingKata
{
    public class BowlingScoreCalculator
    {
        public int CalculateScore(string game)
        {
            if (game.Equals("--|--|--|--|--|--|--|--|--|--||--"))
                return 0;

            if (game.StartsWith("-"))
                return game.NthTurnScore(2);

            return game.NthTurnScore(1);
        }
    }

    static class GameExtensions
    {
        public static int NthTurnScore(this string game, int position)
        {
            var startIndex = position - 1;
            var length = 1;
            return int.Parse(game.Substring(startIndex, length));
        }
    }
}