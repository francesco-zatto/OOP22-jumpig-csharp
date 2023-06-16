using AlessandroVerna;
using FrancescoFilippini;

namespace FrancescoZattoni
{
    public class PlatformCollisionActioner<H, E> : ICollisionActioner<H, E> where H : Hitbox where E : IGameEntity<H>
    {
        public void Act(IPlayer player, E gameEntity)
        {
            throw new NotImplementedException();
        }
    }
}

