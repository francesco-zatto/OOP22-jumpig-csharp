using NUnit.Framework;
using AlessandroVerna;

namespace FrancescoFilippini.Test
{
    public class CameraTest
    {
        private static readonly double WIDTH = 16;
        
        private static readonly double GRAVITY = -10;

        [Test]
        public static void TestSameVelocity()
        {
        var time = 0.0;
        IPlayer player = new PlayerImpl(new PositionImpl(WIDTH / 2, 0));
        ICamera camera = new CameraImpl(player);
        camera.CameraHeight = 0;
        camera.SetCameraHeight(time, player);
        player.ComputePosition(time);
        Assert.AreEqual(player.Position, camera.CameraHeight);
        time = 4.0;
        IPlayer player2 = new PlayerImpl(new PositionImpl(WIDTH / 2, 0));
        camera.CameraHeight = 0;
        camera.SetCameraHeight(time, player2);
        player2.ComputePosition(time);
        Assert.AreEqual(player2.Position, camera.CameraHeight);
        }

        [Test]
        public static void TestCameraMovement()
        {
        IPlayer player = new PlayerImpl(new PositionImpl(WIDTH / 2, 0));
        ICamera camera = new CameraImpl(player);
        var time = 1;
        player.ComputeVelocity(GRAVITY, time, Direction.HorizontalZero);
        camera.CameraHeight = 0;
        camera.SetCameraHeight(time, player); // velocity of the camera should be 0 when player goes down
        Assert.AreEqual(camera.CameraHeight, 0);
        }


    }
}
