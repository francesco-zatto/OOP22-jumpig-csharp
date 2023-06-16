using AlessandroVerna;
using FrancescoFilippini;

namespace FrancescoZattoni
{
    public interface ICollisionHandler<H, E> where H : Hitbox where E : IGameEntity<H>
    {

        void Handle(IPlayer player, E gameEntity);
    }   
}