using AlessandroVerna;

namespace FrancescoFilippini
{
    public abstract class RectangleHitbox : Hitbox
    {
        /*
        * Constructor to create a new rectangular hitbox.
        */
        public RectangleHitbox(PositionImpl center, double width, double height)
        {
            getCenter = center;
            getWidth = width;
            getHeight = height;
        }

        public PositionImpl getCenter{ get; set; }

        public double getWidth{ get; }

        public double getHeight{ get; }

        public double getLeftX => CalculateRectangleCoordinate(true);

        public double getRightX => CalculateRectangleCoordinate(false);

        public double getUpperY => CalculateRectangleCoordinate(false);

        public double getLowerY => CalculateRectangleCoordinate(true);

    /*
     * The boolean isSignNegative is true for lowerY and leftX, because methods to get those coordinates has to
     * subtract the half of dimension from the center coordinate. Instead, isSignNegative is false for upperY and rightY, 
     * because methods to get those coordinates has to add the half of dimension from the center coordinate.
    */
        private double CalculateRectangleCoordinate(bool isSignNegative)
        {
            double dimension = isSignNegative ? getHeight : getWidth;
            double coordinate =  isSignNegative ? getCenter.Y : getCenter.X;
            double sign = isSignNegative ? -1 : 1;
            return coordinate + sign * (dimension / 2);
        }
        
        public void UpdateHitBox(PositionImpl center)
        {
            getCenter = center;
        }
    }
}