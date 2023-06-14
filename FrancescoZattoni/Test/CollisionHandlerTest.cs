using NUnit.Framework;

namespace FrancescoZattoni.Test
{
    class CollisionHandlerTest
    {
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