using AlessandroVerna;

namespace FrancescoFilippini
{
    public abstract class CircleHitbox : IHitbox
    {
        /*
        * Constructor to create a new circular hitbox.
        */
        public CircleHitbox (IPosition center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public IPosition Center { get; set; }

        public double Radius { get; }

        public abstract double LeftX { get; }

        public abstract double RightX { get; }

        public abstract double UpperY { get; }

        public abstract double LowerY { get; }

        /*
        * @inheritdoc
        */

        public void UpdateHitBox(IPosition center) 
        {
            Center = center;
        }
    }

}