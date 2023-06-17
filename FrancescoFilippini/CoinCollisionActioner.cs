using AlessandroVerna;
using FrancescoZattoni;

namespace FrancescoFilippini
{
    public class CoinCollisionActioner<C> : ICollisionActioner<CircleHitbox, C> where C : ICoin
    {
        public void Act(IPlayer player, C gameEntity)
        {
            player.IncrementCoins();
            gameEntity.MarkTarget();
        }
    }
}