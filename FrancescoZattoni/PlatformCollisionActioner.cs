using AlessandroVerna;
using FrancescoFilippini;

namespace FrancescoZattoni
{
    public class PlatformCollisionActioner<P> : ICollisionActioner<RectangleHitbox, P> where P : IPlatform
    {
        public void Act(IPlayer player, P gameEntity)
        {
            var platformJumpVelocity = gameEntity.JumpVelocity;
            player.Velocity = new VelocityImpl(
                player.Velocity.XComponent,
                platformJumpVelocity.YComponent
            );
            player.PlatformHeight = gameEntity.Position.Y;
        }
    }
}

