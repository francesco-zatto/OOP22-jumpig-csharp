using AlessandroVerna;
using FrancescoFilippini;

namespace FrancescoZattoni
{
    public abstract class AbstractPlatform : AbstractGameEntity<RectangleHitbox>, IPlatform
    {
        private readonly IVelocity _jumpVelocity;
        private readonly double _length;

        protected AbstractPlatform(IPosition position, double jumpVelocity)
            : base(position, new PlatformHitbox((PositionImpl)position)) //TODO CANCELLA CASTING
        {
            _jumpVelocity = new VelocityImpl(0, jumpVelocity);
        }

        public IVelocity JumpVelocity => _jumpVelocity;

        public double Length => _length;

        public abstract void handleCollision(IPlayer player);
    }
}