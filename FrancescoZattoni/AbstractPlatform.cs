using AlessandroVerna;
using FrancescoFilippini;

namespace FrancescoZattoni
{
    public abstract class AbstractPlatform : AbstractGameEntity<RectangleHitbox>, IPlatform
    {
        private readonly IVelocity _jumpVelocity;
        private readonly double _length;

        protected AbstractPlatform(IPosition position, double jumpVelocity)
            : base(position, new PlatformHitbox(position)) 
        {
            _jumpVelocity = new VelocityImpl(0, jumpVelocity);
            _length = Hitbox.Width;
        }

        public IVelocity JumpVelocity => _jumpVelocity;

        public double Length => _length;

        public abstract void HandleCollision(IPlayer player);
    }
}