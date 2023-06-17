using AlessandroVerna;

namespace FrancescoFilippini
{
    public abstract class RectangleHitbox : IHitbox
    {
        /*
        * Constructor to create a new rectangular hitbox.
        */
        public RectangleHitbox(IPosition center, double width, double height)
        {
            Center = center;
            Width = width;
            Height = height;
        }

        public IPosition Center{ get; set; }

        public double Width{ get; }

        public double Height{ get; }

        public double LeftX => CalculateRectangleCoordinate(true);

        public double RightX => CalculateRectangleCoordinate(false);

        public double UpperY => CalculateRectangleCoordinate(false);

        public double LowerY => CalculateRectangleCoordinate(true);

    /*
     * The boolean isSignNegative is true for lowerY and leftX, because methods to get those coordinates has to
     * subtract the half of dimension from the center coordinate. Instead, isSignNegative is false for upperY and rightY, 
     * because methods to get those coordinates has to add the half of dimension from the center coordinate.
    */
        private double CalculateRectangleCoordinate(bool isSignNegative)
        {
            double dimension = isSignNegative ? Height : Width;
            double coordinate =  isSignNegative ? Center.Y : Center.X;
            double sign = isSignNegative ? -1 : 1;
            return coordinate + sign * (dimension / 2);
        }
        
        public void UpdateHitBox(IPosition center)
        {
            Center = center;
        }
    }

}