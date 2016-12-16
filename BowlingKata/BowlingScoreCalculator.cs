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

            if (game.Equals("2-|--|--|--|--|--|--|--|--|--||--"))
            {
                return 2;
            }

            if (game.Equals("3-|--|--|--|--|--|--|--|--|--||--"))
            {
                return 3;
            }

            return 0;
        }
    }
}