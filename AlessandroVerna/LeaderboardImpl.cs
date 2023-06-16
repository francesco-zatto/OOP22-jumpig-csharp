namespace AlessandroVerna
{
    public class LeaderboardImpl : ILeaderboard
    {
        private static readonly int TOP_SCORES = 10;
        private readonly List<IScore> _scoreLeaderboard;

        public LeaderboardImpl()
        {
            _scoreLeaderboard = new List<IScore>();
        }

        private LeaderboardImpl(List<IScore> scoreLeaderboard)
        {
            _scoreLeaderboard = scoreLeaderboard;
        }

        public List<IScore> Scores => 
        _scoreLeaderboard.GroupBy(s => s.Username)
            .Select(g => g.OrderByDescending(s => s.HeightScore).ThenByDescending(s => s.Coins).First())
            .OrderByDescending(s => s.HeightScore)
            .ThenByDescending(s => s.Coins)
            .Take(TOP_SCORES)
            .ToList();

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