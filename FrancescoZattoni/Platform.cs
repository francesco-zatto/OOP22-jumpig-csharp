using AlessandroVerna;
using FrancescoFilippini;

namespace FrancescoZattoni
{
    public interface IPlatform : IGameEntity<RectangleHitbox>, Collidable
    {
        IVelocity JumpVelocity {get; }

        double Length {get; }
        
    }
}