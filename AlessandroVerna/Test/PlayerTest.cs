using NUnit.Framework;

namespace AlessandroVerna.Test
{
    class PlayerTest
    {
        [Test]
        public void TestSetters()
        {
            var player = new PlayerImpl(new PositionImpl(5,5));
            Assert.IsTrue(player.Velocity.YComponent == 20);
            player.Velocity = new VelocityImpl(0, 0);
            Assert.IsTrue(player.Velocity.YComponent == 0);
            Assert.AreEqual(1, 1);
            Assert.IsFalse(player.PlatformHeight.HasValue);
            player.PlatformHeight = 10;
            Assert.IsTrue(player.PlatformHeight.HasValue);
        } 
    }
}