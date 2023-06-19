using System;
using FrancescoZattoni;
using AlessandroVerna;

namespace FrancescoFilippini
{
    public class BasicCoin : AbstractGameEntity<CircleHitbox>, ICoin
    {
        private bool taken;
        private readonly ICollisionHandler<CircleHitbox, BasicCoin> collisionHandler = 
            new CollisionHandlerImpl<CircleHitbox, ICoin>(new CoinCollisionActioner<BasicCoin>(), 
            new CoinCollisionChecker());

        public override bool IsTaken => taken;

        public BasicCoin(IPosition position) : base(position, new CoinHitbox(position))
        {
        }

        public override void MarkTarget() => taken = true;

        public override void HandleCollision(IPlayer player) => collisionHandler.Handle(player, this);

        public override CircleHitbox CreateScaledHitbox(IPosition position) => new CoinHitbox(position);

    }
}