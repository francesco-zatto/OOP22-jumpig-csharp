namespace FrancescoZattoni
{
    public class BasicPlatformCollisionChecker : PlatformCollisionChecker<BasicPlatform>
    {
        protected override bool CanEntityCollide(BasicPlatform gameEntity) => true;
    }
}