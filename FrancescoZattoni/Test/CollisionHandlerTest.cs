using NUnit.Framework;
using System.Linq;
using AlessandroVerna;

namespace FrancescoZattoni.Test
{
    class CollisionHandlerTest
    {
        private static readonly double DELTA_TIME = 0.05;
        private static readonly double GRAVITY;

        private static void assertCollision(IPlayer player, IPlatform platform) 
        {

        }

        private static void assertInJumpingRange(IPlayer player, IPlatform platform) {
            /*final var playerLowerY = player.getHitbox().getLowerY();
            assertTrue(playerLowerY > platform.getPosition().getY());
            assertTrue(playerLowerY < platform.getHitbox().getUpperY());*/
        }

        private double computeFallingTime(IPlayer player) {
            return 2 /* * player.getVelocity().getYComponent() / -GRAVITY*/;
        }

        private void computeMovement(IPlayer player, double collisionTime) {
            for (double t = 0.0; t < collisionTime; t = t + DELTA_TIME)
            {
                //player.ComputeVelocity(GRAVITY, t, ((int)Direction.HorizontalZero));
                player.ComputePosition(t);
            }
        }
        [Test]
        public void testBasicPlatformCollision()
        {
            Assert.AreEqual(0, 0);
        }

        [Test]
        public void testPlayerIsNotGoingDown()
        {
            Assert.AreEqual(1, 1);
        }
    }
}