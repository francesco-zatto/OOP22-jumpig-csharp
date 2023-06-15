using FrancescoZattoni;

namespace AlessandroVerna
{
    public class PlayerImpl : AbstractGameEntity, IPlayer
    {
        private static readonly double INITIAL_VELOCITY = 20;
        private static readonly int MAXLIVES = 3;
        private IVelocity _playerVelocity;
        private int _lives = MAXLIVES;
        private int _coins;
        private double? _lastPlatformHeight;

        public PlayerImpl(IPosition position)
        {
            _playerVelocity = new VelocityImpl(0, INITIAL_VELOCITY);
            _coins = 0;
            _lastPlatformHeight = 1.0;
        }

        private PlayerImpl(IPosition position, IVelocity velocity, int coins,
        int lives, double? lastPlatformHeight)
        {
            _playerVelocity = velocity;
            _coins = coins;
            _lives = lives;
            _lastPlatformHeight = lastPlatformHeight;
        }

        public int Lives => _lives;

        public IVelocity Velocity { get => _playerVelocity; set => _playerVelocity = value; }
        public double? PlatformHeight { get => _lastPlatformHeight; set => _lastPlatformHeight = value; }

        public int Coins => _coins;

        public void ComputePosition(double deltaTime)
        {
            throw new NotImplementedException();
        }

        public void ComputeVelocity(double gravity, double deltaTime, Direction direction)
        {
            _playerVelocity.ComputeAcceleratedVelocity(gravity, deltaTime);
            _playerVelocity.ComputeHorizontalVelocity(direction);
        }

        public IPlayer Copy()
        {
            return new PlayerImpl(Position, _playerVelocity, _coins, 
                _lives, _lastPlatformHeight);
        }

        public void DecreaseLives()
        {
            _lives--;
        }

        public void IncrementCoins()
        {
            _coins++;
        }

        public void MoveToEdges(IPosition edge)
        {
            throw new NotImplementedException();
        }
    }
}