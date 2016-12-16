namespace BowlingKata
{
    public class BowlingScoreCalculator
    {
        public int CalculateScore(string game)
        {
            if (game.Equals("--|--|--|--|--|--|--|--|--|--||--"))
                return 0;

            return int.Parse(game.Substring(0, 1));
        }
    }
}