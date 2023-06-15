namespace AlessandroVerna
{
    public class VelocityImpl : IVelocity
    {
        public VelocityImpl(double componentX, double componentY)
        {
            XComponent = componentX;
            YComponent = componentY;
        }
        public double Module => Math.Sqrt(Math.Pow(XComponent, 2) + Math.Pow(YComponent, 2));

        public double XComponent { get; }

        public double YComponent { get; }

        public void ComputeAcceleratedVelocity(double gravity, double deltaTime)
        {
            throw new NotImplementedException();
        }

        public void ComputeHorizontalVelocity(double gravity, double deltaTime)
        {
            throw new NotImplementedException();
        }

        public IPosition ComputeMovement(IPosition initialPosition, double deltaTime)
        {
            throw new NotImplementedException();
        }
    }
}