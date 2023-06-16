namespace AlessandroVerna
{
    public class VelocityImpl : IVelocity
    {
        private static readonly double HORIZONTAL_VELOCITY = 20;
        private double _componentX;
        private double _componentY;

        public VelocityImpl(double componentX, double componentY)
        {
            _componentX = componentX;
            _componentY = componentY;
        }
        public double Module => Math.Sqrt(Math.Pow(_componentX, 2) + Math.Pow(_componentY, 2));

        public double XComponent => _componentX;

        public double YComponent => _componentY;

        public void ComputeAcceleratedVelocity(double gravity, double deltaTime)
        {
            _componentY += gravity * deltaTime;
        }

        public void ComputeHorizontalVelocity(Direction direction)
        {
            _componentX = (double)direction * HORIZONTAL_VELOCITY;
        }

        public IPosition ComputeMovement(IPosition initialPosition, double deltaTime)
        {
            return new PositionImpl(
                initialPosition.X + (_componentX * deltaTime),
                initialPosition.Y + (_componentY * deltaTime)
            );
        }
    }
}