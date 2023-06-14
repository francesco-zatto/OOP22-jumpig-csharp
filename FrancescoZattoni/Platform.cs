using AlessandroVerna;

namespace FrancescoZattoni
{
    public interface IPlatform : IGameEntity, Collidable
    {
        IVelocity JumpVelocity {get; }

        double Length {get; }
        
    }
}