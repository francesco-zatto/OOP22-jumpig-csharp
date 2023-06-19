using System;
using AlessandroVerna;
using FrancescoZattoni;

namespace FrancescoFilippini
{
    public class CoinCollisionChecker : AbstractCollisionChecker<CircleHitbox, ICoin>
    {
        protected override bool AreBoundsColliding(IPlayer player, ICoin gameEntity)
        {
            RectangleHitbox playerHitbox = player.Hitbox;
            CircleHitbox coinHitbox = gameEntity.Hitbox;
            IPosition coinCenter = coinHitbox.Center;
            double playerLeftX = playerHitbox.LeftX;
            double playerRightX = playerHitbox.RightX;
            double playerLowerY = playerHitbox.LowerY;
            double playerUpperY = playerHitbox.UpperY;
            double nearestX = GetNearestRectangleX(playerHitbox, coinCenter);
            double nearestY = GetNearestRectangleY(playerHitbox, coinCenter);
            IPosition nearestPosition;

            if (IsBetween(coinCenter.Y,playerLowerY, playerUpperY)) 
            {
                nearestPosition = new PositionImpl(nearestX, coinCenter.Y);
            } 
            else if (IsBetween(coinCenter.X,playerLeftX, playerRightX))
            {
                nearestPosition = new PositionImpl(coinCenter.X, nearestY);
            }
            else
            {
                nearestPosition = new PositionImpl(nearestX, nearestY);
            }

            return IsPositionInsideCircle(nearestPosition, coinHitbox);
        }

        private bool IsPositionInsideCircle(IPosition position, CircleHitbox circle)
        {
            return Math.Pow(position.X - circle.Center.X, 2) + Math.Pow(position.Y - circle.Center.Y, 2)
                < Math.Pow(circle.Radius,2);
        }

        private double GetNearestRectangleX(RectangleHitbox playerhitbox, IPosition coinCenter)
        {
            return coinCenter.X > playerhitbox.Center.X
                ? playerhitbox.RightX : playerhitbox.LeftX;
        }

        private double GetNearestRectangleY(RectangleHitbox playerhitbox, IPosition coinCenter)
        {
            return coinCenter.Y > playerhitbox.Center.Y 
                ? playerhitbox.UpperY : playerhitbox.LowerY;
        }

        protected override bool CanEntityCollide(ICoin gameEntity) => true;

        protected override bool CanPlayerCollide(IPlayer player) => true;

    }
}