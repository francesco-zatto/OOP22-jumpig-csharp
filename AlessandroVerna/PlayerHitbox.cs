using FrancescoFilippini;

namespace AlessandroVerna
{
    public class PlayerHitbox : RectangleHitbox
    {
        
        private static readonly double PLAYER_WIDTH = 6;
        private static readonly double PLAYER_HEIGHT = 6;

        public PlayerHitbox(IPosition center)
            : base(center, PLAYER_WIDTH, PLAYER_HEIGHT)
        {
        }
    }
}