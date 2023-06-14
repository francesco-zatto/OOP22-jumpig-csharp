using AlessandroVerna;

namespace FrancescoZattoni
{
    public class AbstractGameEntity : IGameEntity
    {
        private readonly IPosition _position;
        public IPosition Position => _position;
    }
}