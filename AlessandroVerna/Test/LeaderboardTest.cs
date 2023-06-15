using NUnit.Framework;

namespace AlessandroVerna.Test
{
    class LeaderboardTest
    {
        private static readonly int HEIGHT_SCORE = 100;
        private static readonly int COINS = 30;
        private static readonly int NUM_SCORES = 13;
        private static Random RANDOM = new();

        [Test]
        public void TestAddLeaderboard()
        {
            var leaderboard = new LeaderboardImpl();
            leaderboard.AddScore(new ScoreImpl("Alessandro", HEIGHT_SCORE, COINS));
            Assert.AreEqual("Alessandro", leaderboard.Scores.ElementAt(0).Username);
        }

        [Test]
        public void TestCopy()
        {
            var leaderboard = new LeaderboardImpl();
            leaderboard.AddScore(new ScoreImpl("Daniel", HEIGHT_SCORE / 2, COINS));
            var copy = leaderboard.Copy();
            Assert.AreNotEqual(copy, leaderboard);
            var copy2 = leaderboard;
            Assert.AreEqual(copy2, leaderboard);
        }
    }
}