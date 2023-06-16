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
            return IsPlayerAligned(playerHitbox, platformHitbox) && IsPlayerAbove(playerHitbox, platformHitbox);
        }

        protected override bool CanPlayerCollide(IPlayer player)
        {
            return player.Velocity.YComponent < 0;
        }

        private bool IsPlayerAligned(RectangleHitbox playerHitbox, RectangleHitbox platformHitbox) {
        double playerLeftX = playerHitbox.getLeftX;
        double playerRightX = playerHitbox.getRightX;
        double platformLeftX = platformHitbox.getLeftX;
        double platformRightX = platformHitbox.getRightX;
        return IsBetween(playerLeftX, platformLeftX, platformRightX) 
            || IsBetween(playerRightX, platformLeftX, platformRightX);
        }

        private bool IsPlayerAbove(RectangleHitbox playerHitbox, RectangleHitbox platformHitbox) {
            return IsBetween(
                playerHitbox.getLowerY, 
                platformHitbox.getCenter.Y, 
                platformHitbox.getUpperY
            );
        }

    }
}