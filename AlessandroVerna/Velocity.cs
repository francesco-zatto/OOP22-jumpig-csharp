namespace AlessandroVerna;
{
    public interface IVelocity
    {
        double Module { get; }

        double XComponent { get; }

        double YComponent { get; }

        IPosition ComputeMovement(IPosition initialPosition, double deltaTime);

        void ComputeAcceleratedVelocity(double gravity, double deltaTime);

        void ComputeHorizontalVelocity(double gravity, double deltaTime);
    }
}