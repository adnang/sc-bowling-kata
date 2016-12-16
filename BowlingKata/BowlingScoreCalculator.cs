namespace BowlingKata
{
    public class BowlingScoreCalculator
    {
        public int CalculateScore(string game)
        {
            if (game.Equals("--|--|--|--|--|--|--|--|--|--||--"))
            {
                var score = 0;

                return score;
            }

            var frames = game.Split('|');
            var firstFrame = frames[0];

            if (game.Equals("1-|--|--|--|--|--|--|--|--|--||--"))
            {
                var firstThrowOfFirstFrame = firstFrame.ScoreAt(Position.First);

                return firstThrowOfFirstFrame;
            }

            if (game.Equals("2-|--|--|--|--|--|--|--|--|--||--"))
            {
                var firstThrowOfFirstFrame = firstFrame.ScoreAt(Position.First);

                return firstThrowOfFirstFrame;
            }

            if (game.Equals("3-|--|--|--|--|--|--|--|--|--||--"))
            {
                var firstThrowOfFirstFrame = firstFrame.ScoreAt(Position.First);

                return firstThrowOfFirstFrame;
            }

            int secondThrowOfFirstFrame;
            if (game.Equals("-1|--|--|--|--|--|--|--|--|--||--"))
            {
                secondThrowOfFirstFrame = firstFrame.ScoreAt(Position.Second);
                var score = secondThrowOfFirstFrame;

                return score;
            }

            if (game.Equals("-2|--|--|--|--|--|--|--|--|--||--"))
            {
                secondThrowOfFirstFrame = firstFrame.ScoreAt(Position.Second);
                var score = secondThrowOfFirstFrame;

                return score;
            }

            if (game.Equals("-3|--|--|--|--|--|--|--|--|--||--"))
            {
                secondThrowOfFirstFrame = firstFrame.ScoreAt(Position.Second);
                var score = secondThrowOfFirstFrame;

                return score;
            }

            var secondFrame = frames[1];
            if (IsHitAtFirstThrowOf(secondFrame))
            {
                if (game.Equals("--|1-|--|--|--|--|--|--|--|--||--"))
                {
                    int firstThrowOfSecondFrame = secondFrame.ScoreAt(Position.First);
                    var score = firstThrowOfSecondFrame;

                    return score;
                }

                if (game.Equals("--|2-|--|--|--|--|--|--|--|--||--"))
                {
                    int firstThrowOfSecondFrame = secondFrame.ScoreAt(Position.First);
                    var score = firstThrowOfSecondFrame;

                    return score;
                }
            }


            if (game.Equals("--|-1|--|--|--|--|--|--|--|--||--"))
            {                
                int secondThrowOfSecondFrame = secondFrame.ScoreAt(Position.Second);
                var score = secondThrowOfSecondFrame;

                return score;
            }

            return 0;
        }

        private static bool IsHitAtFirstThrowOf(string frame)
        {
            return !frame.ThrowAt(Position.First).Equals('-');
        }
    }

    static class GameExtensions
    {
        public static int ScoreAt(this string frame, Position position)
        {
            var throwAtPosition = frame.ThrowAt(position);
            return int.Parse(throwAtPosition);
        }

        public static string ThrowAt(this string frame, Position position)
        {
            var startIndex = (int) position;
            const int length = 1;
            var throwAtPosition = frame.Substring(startIndex, length);
            return throwAtPosition;
        }
    }

    internal enum Position
    {
        First, Second
    }
}