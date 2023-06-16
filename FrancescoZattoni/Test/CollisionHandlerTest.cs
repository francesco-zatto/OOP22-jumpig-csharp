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
        private static readonly double HALF_PLATFORM_HEIGHT = new PlatformHitbox((PositionImpl)STARTING_POSITION).getHeight / 2;
        private static readonly IPosition PLATFORM_UNDER_PLAYER_POSITION = new PositionImpl(
            PLAYER_POSITION_X, 
            new PlayerHitbox(STARTING_POSITION).getLowerY() - HALF_PLATFORM_HEIGHT
    );

        private static void assertCollision(IPlayer player, IPlatform platform) 
        {
            Assert.AreEqual(platform.JumpVelocity.YComponent, player.Velocity.YComponent);
            Assert.IsNotNull(player.PlatformHeight);
            Assert.AreEqual(player.PlatformHeight, platform.Position.Y);
        }

        private static void assertInJumpingRange(IPlayer player, IPlatform platform) {
            /*final var playerLowerY = player.getHitbox().getLowerY();
            assertTrue(playerLowerY > platform.getPosition().getY());
            assertTrue(playerLowerY < platform.getHitbox().getUpperY());*/
        }

        private double computeFallingTime(IPlayer player) {
            return 2 * player.Velocity.YComponent / -GRAVITY;
        }

        private void computeMovement(IPlayer player, double collisionTime) {
            for (double t = 0.0; t < collisionTime; t = t + DELTA_TIME)
            {
                player.ComputeVelocity(GRAVITY, t, (Direction.HorizontalZero));
                player.ComputePosition(t);
            }
        }
        [Test]
        public void testBasicPlatformCollision()
        {
            var player = new PlayerImpl(STARTING_POSITION);
            var platform = new BasicPlatform(PLATFORM_UNDER_PLAYER_POSITION, PLATFORM_VELOCITY);
        final double collisionTime = computeFallingTime(player) - DELTA_TIME;
        computeMovement(player, collisionTime);
        platform.handleCollision(player);
        assertCollision(player, platform);
        }

        [Test]
        public void testPlayerIsNotGoingDown()
        {
            Assert.AreEqual(1, 1);
        }
    }
}