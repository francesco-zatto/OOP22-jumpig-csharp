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
            GetCenter = center;
            GetWidth = width;
            GetHeight = height;
        }

        public PositionImpl GetCenter{ get; set; }

        public double GetWidth{ get; }

        public double GetHeight{ get; }

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
            double dimension = isSignNegative ? GetHeight : GetWidth;
            double coordinate =  isSignNegative ? GetCenter.Y : GetCenter.X;
            double sign = isSignNegative ? -1 : 1;
            return coordinate + sign * (dimension / 2);
        }
        
        public void UpdateHitBox(PositionImpl center)
        {
            GetCenter = center;
        }
    }
}