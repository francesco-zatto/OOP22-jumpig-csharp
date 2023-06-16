using FrancescoFilippini;
using FrancescoZattoni;

namespace AlessandroVerna
{
    public interface IPlayer : IGameEntity<RectangleHitbox>
    {
        int Lives{ get; }

        IVelocity Velocity{ get; set; }

        double? PlatformHeight{ get; set; }

        int Coins{ get; }

        void DecreaseLives();

        void ComputeVelocity(double gravity, double deltaTime, Direction direction);

        void IncrementCoins();

        void ComputePosition(double deltaTime);

        IPlayer Copy();

        void MoveToEdges(IPosition corner);
    }
}