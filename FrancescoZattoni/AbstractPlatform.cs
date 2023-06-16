using AlessandroVerna;

namespace FrancescoZattoni
{
    public abstract class AbstractPlatform : AbstractGameEntity, IPlatform
    {
        private readonly IVelocity _jumpVelocity;
        private readonly double _length;

        protected AbstractPlatform(IPosition position, double jumpVelocity) : base(position)
        {
            
        }

        public IVelocity JumpVelocity => _jumpVelocity;

        public double Length => _length;

        public abstract void handleCollision(IPlayer player);
    }
}