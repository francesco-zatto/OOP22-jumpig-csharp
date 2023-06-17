using AlessandroVerna;

namespace FrancescoFilippini
{
    public interface ICamera
    {
        ICamera copy(IPlayer player);

        int CameraStartHeight{ get; set; }

        void SetCameraVelocity(IPlayer player);

        double CameraHeight{ get; }

        void SetCameraHeight(double time, IPlayer player);

        double? PlatformHeight{ get; set; }
    }
}