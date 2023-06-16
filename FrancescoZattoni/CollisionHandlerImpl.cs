using AlessandroVerna;
using FrancescoFilippini;

namespace FrancescoZattoni
{
    public class CollisionHandlerImpl<H, E> : ICollisionHandler<H, E> where H : Hitbox where E : IGameEntity<H>
    {
        private readonly ICollisionActioner<H, E> _collisionActioner;
        private readonly ICollisionChecker<H, E> _collisionChecker;

        public CollisionHandlerImpl(ICollisionActioner<H, E> collisionActioner, ICollisionChecker<H, E> collisionChecker)
        {
            _collisionActioner = collisionActioner;
            _collisionChecker = collisionChecker;
        }

        public void Handle(IPlayer player, E gameEntity)
        {
            if (_collisionChecker.Check(player, gameEntity))
            {
                _collisionActioner.Act(player, gameEntity);
            }
        }
    }
}