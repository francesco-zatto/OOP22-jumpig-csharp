using AlessandroVerna;

namespace FrancescoZattoni
{
    public abstract class AbstractPlatform : AbstractGameEntity, IPlatform
    {
        private readonly IVelocity _jumpVelocity;
        private readonly double _length;
        
        public IVelocity JumpVelocity => _jumpVelocity;

        public double Length => _length;

        public abstract void handleCollision(IPlayer player);
    }
}