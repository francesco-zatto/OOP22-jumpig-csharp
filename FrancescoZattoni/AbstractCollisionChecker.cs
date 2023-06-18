using AlessandroVerna;
using FrancescoFilippini;

namespace FrancescoZattoni
{
    public abstract class AbstractCollisionChecker<H, E> : ICollisionChecker<H, E> where H : IHitbox where E : IGameEntity<H>
    {

        public bool Check(IPlayer player, E gameEntity) {
            return CanPlayerCollide(player)
                && CanEntityCollide(gameEntity)
                && AreBoundsColliding(player, gameEntity);
        }

        protected abstract bool AreBoundsColliding(IPlayer player, E gameEntity);

        protected abstract bool CanPlayerCollide(IPlayer player);

        protected abstract bool CanEntityCollide(E gameEntity);

        protected static bool IsBetween(double num, double min, double max) {
            return min <= num && num <= max;
        }
        
    }   
}