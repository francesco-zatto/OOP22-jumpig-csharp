using AlessandroVerna;
using FrancescoFilippini;

namespace FrancescoZattoni
{
    public interface ICollisionActioner<H, E> where H : IHitbox where E : IGameEntity<H>
    {
        void Act(IPlayer player, E gameEntity);
    }
}