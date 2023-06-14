namespace AlessandroVerna;

public interface IVelocity
{
    double Module { get; }

    double XComponent { get; }

    double YComponent { get; }

    IPosition computeMovement(IPosition initialPosition, double deltaTime);

    void computeAcceleratedVelocity(double gravity, double deltaTime);

    void computeHorizontalVelocity(double gravity, double deltaTime);
}