using AlessandroVerna;
using FrancescoFilippini;

namespace FrancescoZattoni
{
    public abstract class AbstractCollisionChecker<H, E> : ICollisionChecker<H, E> where H : Hitbox where E : IGameEntity<H>
    {

        public bool Check(IPlayer player, E gameEntity) {
            return canPlayerCollide(player)
                && canEntityCollide(gameEntity)
                && areBoundsColliding(player, gameEntity);
        }

        protected abstract bool areBoundsColliding(IPlayer player, E gameEntity);

        protected abstract bool canPlayerCollide(IPlayer player);

        protected abstract bool canEntityCollide(E gameEntity);

        protected static bool isBetween(double num, double min, double max) {
            return min <= num && num <= max;
        }
        
    }   
}