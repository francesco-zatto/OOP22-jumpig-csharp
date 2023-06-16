using AlessandroVerna;
using FrancescoFilippini;

namespace FrancescoZattoni
{
    public abstract class PlatformCollisionChecker<P> : AbstractCollisionChecker<RectangleHitbox, P> where P : IPlatform
    {

        protected override bool areBoundsColliding(IPlayer player, P gameEntity)
        {
            /*RectangleHitbox playerHitbox = player.getHitbox();
            RectangleHitbox platformHitbox = gameEntity.getHitbox();*/
            return true/*isPlayerAligned(playerHitbox, platformHitbox) && isPlayerAbove(playerHitbox, platformHitbox)*/;
        }

        protected override bool canPlayerCollide(IPlayer player)
        {
            return player.Velocity.YComponent < 0;
        }

        private bool isPlayerAligned(RectangleHitbox playerHitbox, RectangleHitbox platformHitbox) {
        double playerLeftX = playerHitbox.getLeftX;
        double playerRightX = playerHitbox.getRightX;
        double platformLeftX = platformHitbox.getLeftX;
        double platformRightX = platformHitbox.getRightX;
        return isBetween(playerLeftX, platformLeftX, platformRightX) 
            || isBetween(playerRightX, platformLeftX, platformRightX);
        }

        private bool isPlayerAbove(RectangleHitbox playerHitbox, RectangleHitbox platformHitbox) {
            return isBetween(
                playerHitbox.getLowerY, 
                platformHitbox.getCenter.Y, 
                platformHitbox.getUpperY
            );
        }

    }
}