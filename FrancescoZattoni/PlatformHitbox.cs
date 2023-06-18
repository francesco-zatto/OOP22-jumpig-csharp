using AlessandroVerna;
using FrancescoFilippini;

namespace FrancescoZattoni
{
    public class PlatformHitbox : RectangleHitbox
    {

        private static readonly double PLATFORM_WIDTH = 8; 
        private static readonly double PLATFORM_HEIGHT = 2;
        public PlatformHitbox(IPosition center)
            : base(center, PLATFORM_WIDTH, PLATFORM_HEIGHT)
        {
        }
    }
}