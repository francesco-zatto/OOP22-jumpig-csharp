using AlessandroVerna;

namespace FrancescoZattoni
{
    public class BasicPlatform : AbstractPlatform
    {
        public BasicPlatform(IPosition position, double jumpVelocity) : base(position, jumpVelocity)
        {
            
        }

        public override void handleCollision(IPlayer player) => Console.WriteLine("");
    }
}