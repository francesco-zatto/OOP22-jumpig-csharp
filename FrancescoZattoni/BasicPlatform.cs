using AlessandroVerna;
using FrancescoFilippini;

namespace FrancescoZattoni
{
    public class BasicPlatform : AbstractPlatform
    {

        private readonly ICollisionHandler<RectangleHitbox, BasicPlatform> _collisionHandler = new CollisionHandlerImpl<RectangleHitbox, BasicPlatform>(
            new PlatformCollisionActioner<RectangleHitbox, BasicPlatform>(),
            new BasicPlatformCollisionChecker()
        );

        public BasicPlatform(IPosition position, double jumpVelocity) : base(position, jumpVelocity)
        {  
        }

        public override RectangleHitbox CreateScaledHitbox(IPosition position) => new PlatformHitbox((PositionImpl)position);

        public override void HandleCollision(IPlayer player) => _collisionHandler.Handle(player, this);

    }
}