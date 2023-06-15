namespace AlessandroVerna
{
    public class PositionImpl : IPosition
    {
        public PositionImpl(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X { get; }

        public double Y { get; }
    }
}