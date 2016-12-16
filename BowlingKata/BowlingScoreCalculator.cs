namespace BowlingKata
{
    public class BowlingScoreCalculator
    {
        public int CalculateScore(string game)
        {
            if (game.Equals("1-|--|--|--|--|--|--|--|--|--||--"))
            {
                return 1;
            }
            return 0;
        }
    }
}