using System;
using FrancescoZattoni;
using AlessandroVerna;

namespace FrancescoFilippini
{
    public class BasicCoin : AbstractGameEntity<CircleHitbox>, ICoin
    {
        private bool taken;
        private readonly ICollisionHandler<CircleHitbox, ICoin> collisionHandler = 
            new CollisionHandlerImpl<CircleHitbox, ICoin>(new CoinCollisionActioner(), 
            new CoinCollisionChecker());

        public override bool IsTaken => taken;

        public BasicCoin(IPosition position) : base(position, new CoinHitbox(position))
        {
        }

        public override void MarkTarget() => taken = true;

        public override CircleHitbox CreateScaledHitbox(IPosition position) => new CoinHitbox(position);

    }
}