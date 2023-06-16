using NUnit.Framework;

namespace AlessandroVerna.Test
{
    class PlayerTest
    {
        [Test]
        public void TestSetters()
        {
            var player = new PlayerImpl(new PositionImpl(5, 5));
            Assert.IsTrue(player.Velocity.YComponent == 20);
            player.Velocity = new VelocityImpl(0, 0);
            Assert.IsTrue(player.Velocity.YComponent == 0);
            Assert.AreEqual(1, 1);
            Assert.IsTrue(player.PlatformHeight.HasValue);
            player.PlatformHeight = 10;
            Assert.IsTrue(player.PlatformHeight.HasValue);
        }

        [Test]
        public void TestLives()
        {
            var player = new PlayerImpl(new PositionImpl(5, 5));
            Assert.AreEqual(3, player.Lives);
            player.DecreaseLives();
            Assert.AreEqual(2, player.Lives);
            player.DecreaseLives();
            player.DecreaseLives();
            Assert.AreEqual(0, player.Lives);
        } 

        [Test]
        public void TestCoins()
        {
            var player = new PlayerImpl(new PositionImpl(3, 6));
            Assert.AreEqual(0, player.Coins);
            int bound = 10;
            CoinIterator(bound, player);
            Assert.AreEqual(bound, player.Coins);
            player.IncrementCoins();
            Assert.AreEqual(bound + 1, player.Coins);
        }

        private static void CoinIterator(int bound, IPlayer player)
        {
            for(int i = 0; i < bound; i++)
            {
                player.IncrementCoins();
            }
        }
    }
}