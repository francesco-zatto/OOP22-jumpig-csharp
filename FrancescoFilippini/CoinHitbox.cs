using System;
using AlessandroVerna;

namespace FrancescoFilippini
{
    public class CoinHitbox : CircleHitbox
    {
        private static readonly double COIN_RADIUS = 1.5;

        public CoinHitbox(IPosition center) : base(center, COIN_RADIUS)
        {
        }

        public override double LeftX => Center.X - Radius;

        public override double LowerY => Center.Y - Radius;

        public override double RightX => Center.X + Radius;

        public override double UpperY => Center.Y + Radius;
    }

}