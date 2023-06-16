using AlessandroVerna;
using FrancescoFilippini;

namespace FrancescoZattoni
{
    public abstract class AbstractGameEntity<H> : IGameEntity<H> where H : Hitbox
    {
        private IPosition _position;
        private readonly H _hitbox;

        protected AbstractGameEntity(IPosition position, H hitbox)
        {
            _position = position;
            _hitbox = hitbox;

        }

        public IPosition Position 
        {
            get => _position;
            protected set => _position = value;
        }

        public H Hitbox => _hitbox;

        public abstract H CreateScaledHitbox(IPosition position);

        public override bool Equals(object? obj)
        {
            return obj is AbstractGameEntity<H> entity 
                   && EqualityComparer<IPosition>.Default.Equals(Position, entity.Position)
                   && EqualityComparer<H>.Default.Equals(Hitbox, entity.Hitbox);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Position, Hitbox);
        }
    }
}