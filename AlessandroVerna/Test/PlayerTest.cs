using NUnit.Framework;

namespace AlessandroVerna.Test
{
    class PlayerTest
    {
        private static readonly double PLAYER_COMPONENT_X = 5;
        private static readonly double PLAYER_COMPONENT_Y = 10;
        private static readonly double GRAVITY = 10.0;

        [Test]
        public void TestSetters()
        {
            var player = new PlayerImpl(new PositionImpl(PLAYER_COMPONENT_X, PLAYER_COMPONENT_Y));
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
            var player = new PlayerImpl(new PositionImpl(PLAYER_COMPONENT_X, PLAYER_COMPONENT_Y));
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
            var player = new PlayerImpl(new PositionImpl(PLAYER_COMPONENT_X, PLAYER_COMPONENT_Y));
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

        [Test]
        public void TestPlayerPosition()
        {
            double time = 0.0;
            var player = new PlayerImpl(new PositionImpl(PLAYER_COMPONENT_X, PLAYER_COMPONENT_Y))
            {
                Velocity = new VelocityImpl(5, 5)
            };
            player.ComputePosition(time);
            Assert.AreEqual(PLAYER_COMPONENT_X, player.Position.X);
            Assert.AreEqual(PLAYER_COMPONENT_Y, player.Position.Y);
            time = 2.0;
            player.ComputePosition(time);
            Assert.AreEqual(PLAYER_COMPONENT_X + (player.Velocity.XComponent * time),
                player.Position.X);
            Assert.AreEqual(PLAYER_COMPONENT_Y + (player.Velocity.YComponent * time),
                player.Position.Y);
        }

        [Test]
        public void TestPlayerVelocity()
        {
            double time = 0.0;
            var player = new PlayerImpl(new PositionImpl(PLAYER_COMPONENT_X, PLAYER_COMPONENT_Y));
            player.Velocity = new VelocityImpl(5, 5);
            player.ComputeVelocity(GRAVITY, time, Direction.HorizontalZero);
            Assert.AreEqual(0, player.Velocity.XComponent);
            Assert.AreEqual(5, player.Velocity.YComponent);
            time = 1.0;
            player.ComputeVelocity(GRAVITY, time, Direction.HorizontalDx);
            Assert.AreEqual(5 + (GRAVITY * time), player.Velocity.YComponent);
            Assert.AreEqual(20, player.Velocity.XComponent);
            var preVelocity = player.Velocity.YComponent;
            time = 2.0;
            player.ComputeVelocity(GRAVITY, time, Direction.HorizontalSx);
            Assert.AreEqual(-20, player.Velocity.XComponent);
            Assert.AreEqual(preVelocity + (GRAVITY * time), player.Velocity.YComponent);
        }
    }
}