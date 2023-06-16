namespace FrancescoZattoni
{
    public class BasicPlatformCollisionChecker : PlatformCollisionChecker<BasicPlatform>
    {
        protected override bool canEntityCollide(BasicPlatform gameEntity)
        {
            return true;
        }
    }
}