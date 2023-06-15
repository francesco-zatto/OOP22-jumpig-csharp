namespace AlessandroVerna
{
    public class ScoreImpl : IScore
    {

        public ScoreImpl(string username, int heightScore, int coins)
        {
            Username = username;
            HeightScore = heightScore;
            Coins = coins;
        }
        
        public string Username { get; }

        public int HeightScore { get; }

        public int Coins { get; }
    }
}