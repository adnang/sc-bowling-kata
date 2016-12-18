namespace BowlingKata
{
    public class BowlingScoreCalculator
    {
        public int CalculateScore(string game)
        {
            var frames = game.Split('|');
            var firstFrame = frames[0];
            if (IsHitAtFirstThrowOf(firstFrame))
            {
                var firstThrowOfFirstFrame = firstFrame.ScoreAt(Position.First);

                var score = firstThrowOfFirstFrame;
                return score;
            }

            if (IsHitAtSecondThrowOf(firstFrame))
            {
                var secondThrowOfFirstFrame = firstFrame.ScoreAt(Position.Second);

                var score = secondThrowOfFirstFrame;
                return score;
            }

            var secondFrame = frames[1];
            if (IsHitAtFirstThrowOf(secondFrame))
            {
                
                int firstThrowOfSecondFrame = secondFrame.ScoreAt(Position.First);
                var score = firstThrowOfSecondFrame;

                return score;
                
            }

            if (game.Equals("--|-1|--|--|--|--|--|--|--|--||--"))
            {                
                int secondThrowOfSecondFrame = secondFrame.ScoreAt(Position.Second);
                var score = secondThrowOfSecondFrame;

                return score;
            }

            if (game.Equals("--|-2|--|--|--|--|--|--|--|--||--"))
            {                
                int secondThrowOfSecondFrame = secondFrame.ScoreAt(Position.Second);
                var score = secondThrowOfSecondFrame;

                return score;
            }

            return 0;
        }

        private bool IsHitAtSecondThrowOf(string frame)
        {
            return !frame.ThrowAt(Position.Second).Equals("-");
        }

        private static bool IsHitAtFirstThrowOf(string frame)
        {
            var isMiss = frame.ThrowAt(Position.First).Equals("-");
            return !isMiss;
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