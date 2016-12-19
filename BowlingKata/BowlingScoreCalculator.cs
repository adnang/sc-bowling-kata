namespace BowlingKata
{
    public class BowlingScoreCalculator
    {
        public int CalculateScore(string game)
        {
            var frames = game.Split('|');

            var firstFrame = frames[0];
            var score = firstFrame.Score();

            var secondFrame = frames[1];
            score += secondFrame.Score();

            var thirdFrame = frames[2];
            score += thirdFrame.Score();

            return score;
        }
    }

    static class FrameExtensions
    {
        public static int Score(this string frame)
        {
            var score = 0;
            if (IsHitAtFirstThrowOf(frame))
            {
                var firstThrowOfFrame = frame.ScoreAt(Position.First);
                score = firstThrowOfFrame;
            }

            if (IsHitAtSecondThrowOf(frame))
            {
                var secondThrowOfFrame = frame.ScoreAt(Position.Second);
                score += secondThrowOfFrame;
            }
            return score;
        }

        private static bool IsHitAtFirstThrowOf(string frame)
        {
            var isMiss = frame.ThrowAt(Position.First).Equals("-");
            return !isMiss;
        }

        private static bool IsHitAtSecondThrowOf(string frame)
        {
            var isMiss = frame.ThrowAt(Position.Second).Equals("-");
            return !isMiss;
        }

        private static string ThrowAt(this string frame, Position position)
        {
            const int length = 1;
            var startIndex = (int) position;
            var throwAtPosition = frame.Substring(startIndex, length);
            return throwAtPosition;
        }

        private static int ScoreAt(this string frame, Position position)
        {
            var throwAtPosition = frame.ThrowAt(position);
            return int.Parse(throwAtPosition);
        }
    }

    internal enum Position
    {
        First, Second
    }
}