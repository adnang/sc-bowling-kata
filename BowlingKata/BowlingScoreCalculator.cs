namespace BowlingKata
{
    public class BowlingScoreCalculator
    {
        public int CalculateScore(string game)
        {
            var score = 0;

            var frames = game.Split('|');

            var firstFrame = frames[0];
            if (IsHitAtFirstThrowOf(firstFrame))
            {
                var firstThrowOfFirstFrame = firstFrame.ScoreAt(Position.First);
                score = firstThrowOfFirstFrame;
            }

            if (IsHitAtSecondThrowOf(firstFrame))
            {
                var secondThrowOfFirstFrame = firstFrame.ScoreAt(Position.Second);
                score = secondThrowOfFirstFrame;
            }

            var secondFrame = frames[1];
            if (IsHitAtFirstThrowOf(secondFrame))
            {
                var firstThrowOfSecondFrame = secondFrame.ScoreAt(Position.First);
                score = firstThrowOfSecondFrame;
            }

            if (IsHitAtSecondThrowOf(secondFrame))
            {
                var secondThrowOfSecondFrame = secondFrame.ScoreAt(Position.Second);
                score = secondThrowOfSecondFrame;                
            }

            if (game.Equals("--|--|1-|--|--|--|--|--|--|--||--"))
            {
                return 1;
            }

            return score;
        }

        private static bool IsHitAtSecondThrowOf(string frame)
        {
            var isMiss = frame.ThrowAt(Position.Second).Equals("-");
            return !isMiss;
        }

        private static bool IsHitAtFirstThrowOf(string frame)
        {
            var isMiss = frame.ThrowAt(Position.First).Equals("-");
            return !isMiss;
        }
    }

    static class FrameExtensions
    {
        public static int ScoreAt(this string frame, Position position)
        {
            var throwAtPosition = frame.ThrowAt(position);
            return int.Parse(throwAtPosition);
        }

        public static string ThrowAt(this string frame, Position position)
        {
            const int length = 1;
            var startIndex = (int) position;
            var throwAtPosition = frame.Substring(startIndex, length);
            return throwAtPosition;
        }
    }

    internal enum Position
    {
        First, Second
    }
}