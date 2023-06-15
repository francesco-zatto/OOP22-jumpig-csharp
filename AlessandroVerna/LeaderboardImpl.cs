using System.Collections;

namespace AlessandroVerna
{
    public class LeaderboardImpl : ILeaderboard
    {
        private static int TOP_SCORES = 10;
        private List<IScore> _scoreLeaderboard;

        public LeaderboardImpl()
        {
            _scoreLeaderboard = new List<IScore>();
        }

        private LeaderboardImpl(List<IScore> scoreLeaderboard)
        {
            _scoreLeaderboard = scoreLeaderboard;
        }

        public List<IScore> Scores => _scoreLeaderboard;

        public void AddScore(IScore score)
        {
            _scoreLeaderboard.Add(score);
        }

        public ILeaderboard Copy()
        {
            return new LeaderboardImpl(_scoreLeaderboard);
        }
    }
}