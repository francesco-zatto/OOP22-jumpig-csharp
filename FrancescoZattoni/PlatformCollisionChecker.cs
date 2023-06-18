using AlessandroVerna;
using FrancescoFilippini;

namespace FrancescoZattoni
{
    public abstract class PlatformCollisionChecker<P> : AbstractCollisionChecker<RectangleHitbox, P> where P : IPlatform
    {

        protected override bool AreBoundsColliding(IPlayer player, P gameEntity)
        {
            RectangleHitbox playerHitbox = player.Hitbox;
            RectangleHitbox platformHitbox = gameEntity.Hitbox;
            return IsPlayerAligned(playerHitbox, platformHitbox) 
                && IsPlayerAbove(playerHitbox, platformHitbox);
        }

        protected override bool CanPlayerCollide(IPlayer player) => player.Velocity.YComponent < 0;

        private bool IsPlayerAligned(RectangleHitbox playerHitbox, RectangleHitbox platformHitbox) {
        double playerLeftX = playerHitbox.LeftX;
        double playerRightX = playerHitbox.RightX;
        double platformLeftX = platformHitbox.LeftX;
        double platformRightX = platformHitbox.RightX;
        return IsBetween(playerLeftX, platformLeftX, platformRightX) 
            || IsBetween(playerRightX, platformLeftX, platformRightX);
        }

        private bool IsPlayerAbove(RectangleHitbox playerHitbox, RectangleHitbox platformHitbox) {
            return IsBetween(
                playerHitbox.LowerY, 
                platformHitbox.Center.Y, 
                platformHitbox.UpperY
            );
        }

    }
}