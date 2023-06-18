using NUnit.Framework;
using System.Linq;
using AlessandroVerna;

namespace FrancescoZattoni.Test
{
    class CollisionHandlerTest
    {
        private static readonly double DELTA_TIME = 0.05;
        private static readonly double GRAVITY = -9;
        private static readonly double PLAYER_POSITION_X = 5;
        private static readonly double PLAYER_POSITION_Y = 6.5;
        private static readonly double PLATFORM_VELOCITY = 10;
        private static readonly IPosition STARTING_POSITION = new PositionImpl(PLAYER_POSITION_X, PLAYER_POSITION_Y);
        private static readonly double HALF_PLATFORM_HEIGHT = new PlatformHitbox(STARTING_POSITION).Height / 2;
        private static readonly IPosition PLATFORM_UNDER_PLAYER_POSITION = new PositionImpl(
            PLAYER_POSITION_X, 
            new PlayerHitbox(STARTING_POSITION).LowerY - HALF_PLATFORM_HEIGHT
        );

        private static void AssertCollision(IPlayer player, IPlatform platform) 
        {
            Assert.AreEqual(platform.JumpVelocity.YComponent, player.Velocity.YComponent);
            Assert.IsNotNull(player.PlatformHeight);
            Assert.AreEqual(player.PlatformHeight, platform.Position.Y);
        }

        private static void AssertInJumpingRange(IPlayer player, IPlatform platform) {
            double playerLowerY = player.Hitbox.LowerY;
            Assert.IsTrue(playerLowerY > platform.Position.Y);
            Assert.IsTrue(playerLowerY < platform.Hitbox.UpperY);
        }

        private double ComputeFallingTime(IPlayer player) {
            return 2 * player.Velocity.YComponent / -GRAVITY;
        }

        private void ComputeMovement(IPlayer player, double collisionTime) {
            for (double t = 0.0; t < collisionTime; t = t + DELTA_TIME)
            {
                player.ComputeVelocity(GRAVITY, DELTA_TIME, (Direction.HorizontalZero));
                player.ComputePosition(DELTA_TIME);
            }
        }
        
        [Test]
        public void TestBasicPlatformCollision()
        {
            IPlayer player = new PlayerImpl(STARTING_POSITION);
            IPlatform platform = new BasicPlatform(PLATFORM_UNDER_PLAYER_POSITION, PLATFORM_VELOCITY);
            double collisionTime = ComputeFallingTime(player) - DELTA_TIME;
            ComputeMovement(player, collisionTime);
            platform.HandleCollision(player);
            AssertCollision(player, platform);
        }

        [Test]
        public void TestPlayerIsNotGoingDown()
        {
            IPlayer player = new PlayerImpl(STARTING_POSITION);
            IPlatform platform = new BasicPlatform(PLATFORM_UNDER_PLAYER_POSITION, PLATFORM_VELOCITY);
            platform.HandleCollision(player);
            /* The player jumps on a platform only if he is going down, i.e yComponent is negative.*/
            Assert.IsTrue(player.Velocity.YComponent >= 0);
            Assert.AreNotEqual(player.Velocity.YComponent, platform.JumpVelocity.YComponent);
        }
    }
}