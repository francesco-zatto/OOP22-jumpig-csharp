using AlessandroVerna;
using FrancescoFilippini;

namespace FrancescoZattoni
{
    public interface ICollisionChecker<H, E> where H : Hitbox where E : IGameEntity<H>
    {
        bool Check(IPlayer player, E gameEntity);
    } 
}