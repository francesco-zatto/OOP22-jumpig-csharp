using AlessandroVerna;
using FrancescoZattoni;

namespace FrancescoFilippini
{
    public class CoinCollisionActioner : ICollisionActioner<CircleHitbox, ICoin>
    {
        public void Act(IPlayer player, ICoin gameEntity)
        {
            player.IncrementCoins();
            gameEntity.MarkTarget();
        }
    }
}