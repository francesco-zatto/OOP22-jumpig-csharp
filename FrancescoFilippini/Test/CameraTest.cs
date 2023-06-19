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
        player.ComputeVelocity(GRAVITY, time, Direction.HorizontalZero);
        player.ComputePosition(time);
        camera.SetCameraVelocity(player);
        camera.SetCameraHeight(time, player);
        Assert.AreEqual(player.Position.Y, camera.CameraHeight);
        time = 4.0;
        IPlayer player2 = new PlayerImpl(new PositionImpl(WIDTH / 2, 0));
        camera.CameraHeight = 0;
        player2.ComputeVelocity(GRAVITY * (-1), time, Direction.HorizontalZero);
        player2.ComputePosition(time);
        camera.SetCameraVelocity(player2);
        camera.SetCameraHeight(time, player2);
        Assert.AreEqual(player2.Position.Y, camera.CameraHeight);
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
