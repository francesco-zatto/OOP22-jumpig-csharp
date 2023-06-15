namespace AlessandroVerna;
{
    public interface ILeaderboard
    {
        List<IScore> Scores { get; }

        void AddScore(IScore score);

        ILeaderboard copy();
    }
}