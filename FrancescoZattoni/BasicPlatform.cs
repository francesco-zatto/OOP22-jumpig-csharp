using AlessandroVerna;
using FrancescoFilippini;

namespace FrancescoZattoni
{
    public class BasicPlatform : AbstractPlatform
    {
        public BasicPlatform(IPosition position, double jumpVelocity) : base(position, jumpVelocity)
        {
            
        }

        public override RectangleHitbox CreateScaledHitbox(IPosition position) => new PlatformHitbox((PositionImpl)position);

        public override void handleCollision(IPlayer player) => Console.WriteLine("");
    }
}