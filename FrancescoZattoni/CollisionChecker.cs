using AlessandroVerna;
using FrancescoFilippini;

namespace FrancescoZattoni
{
    public interface ICollisionChecker<H, E> where H : IHitbox where E : IGameEntity<H>
    {
        bool Check(IPlayer player, E gameEntity);
    } 
}