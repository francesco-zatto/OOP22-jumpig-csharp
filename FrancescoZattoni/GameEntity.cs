using AlessandroVerna;
using FrancescoFilippini;

namespace FrancescoZattoni
{
    public interface IGameEntity<H> where H : Hitbox
    {
        IPosition Position {get; }

        public H Hitbox {get; }

        H CreateScaledHitbox(IPosition position);
    }
}