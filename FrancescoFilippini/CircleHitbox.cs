using AlessandroVerna;

namespace FrancescoFilippini
{
    public abstract class CircleHitbox : Hitbox
    {
        public CircleHitbox (PositionImpl center, double radius)
        {
            GetCenter = center;
            GetRadius = radius;
        }
        public PositionImpl GetCenter { get; set; }
        public double GetRadius { get; }
        public double getLeftX { get; }
        public double getRightX { get; }
        public double getUpperY { get; }
        public double getLowerY { get; }

        public void UpdateHitBox(PositionImpl center) 
        {
            GetCenter = center;
        }
    }
}