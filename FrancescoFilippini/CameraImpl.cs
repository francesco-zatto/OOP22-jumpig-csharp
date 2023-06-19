using AlessandroVerna;

namespace FrancescoFilippini
{
    public class CameraImpl : ICamera
    {
        private int startHeight;
        private double cameraHeight;
        private IVelocity cameraVelocity;
        private double? lastPlatform;

        public CameraImpl(IPlayer player)
        {
            startHeight = 0;
            CameraHeight = 0;
            cameraVelocity = new VelocityImpl(0, 0);
            lastPlatform = player?.PlatformHeight;
        }

        public int CameraStartHeight 
        { 
            get => startHeight; 
            set => startHeight = value; 
        }

        public double CameraHeight 
        { 
            get => cameraHeight;
            set => cameraHeight = value;
        }

        public double? PlatformHeight 
        { 
            get => lastPlatform; 
            set => lastPlatform = value; 
        }

        public ICamera copy(IPlayer player)
        {
            return new CameraImpl(player);
        }

        public void SetCameraHeight(double time, IPlayer player)
        {
            if (CameraHeight <= player.Position.Y )
            {
                CameraHeight = CameraHeight + cameraVelocity.YComponent * time;
            }
        }

        public void SetCameraVelocity(IPlayer player)
        {
            if (CheckToSetCameraVelocity(player))
            {
                cameraVelocity = player.Velocity;
            }
            if (player.Velocity.YComponent < 0)
            {
                cameraVelocity = new VelocityImpl(0, 0);
            }
            
        }

        private bool CheckToSetCameraVelocity(IPlayer player)
        {
            return player.PlatformHeight.HasValue
                && (!lastPlatform.HasValue || 
                        player.PlatformHeight.Value.Equals(lastPlatform.Value))
                && player.Velocity.YComponent >= 0;
        }
    }

}