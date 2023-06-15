using AlessandroVerna;

namespace FrancescoFilippini
{
    public abstract class CircleHitbox : Hitbox
    {
        /*
        * Constructor to create a new circular hitbox.
        */
        public CircleHitbox (PositionImpl center, double radius)
        {
            getCenter = center;
            getRadius = radius;
        }

        public PositionImpl getCenter { get; set; }

        public double getRadius { get; }

        public double getLeftX { get; }

        public double getRightX { get; }

        public double getUpperY { get; }

        public double getLowerY { get; }

        /*
        * @inheritdoc
        */

        public void UpdateHitBox(PositionImpl center) 
        {
            getCenter = center;
        }
    }
}