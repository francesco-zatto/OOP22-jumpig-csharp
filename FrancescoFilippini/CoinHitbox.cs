using AlessandroVerna;

namespace FrancescoFilippini
{
    public class CoinHitbox : CircleHitbox
    {
        private static readonly double COIN_RADIUS = 1.5;
        
        public CoinHitbox(IPosition center) : base(center, COIN_RADIUS)
        {

        }
    }
}