using FrancescoZattoni;

namespace AlessandroVerna;
{
    public interface IPlayer : IGameEntity
    {
        int Lives{ get; }

        IVelocity Velocity{ get; set; }

        double? PlatformHeight{ get; set; }

        int Coins{ get; }

        void DecreaseLives();

        void ComputeVelocity(double gravity, double deltaTime, Direction direction);

        void IncrementCoins();

        void ComputePosition(double deltaTime);

        IPlayer copy();

        void MoveToEdges(IPosition edge);
    }
}