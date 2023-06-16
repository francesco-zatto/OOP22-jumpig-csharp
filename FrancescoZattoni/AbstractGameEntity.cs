using AlessandroVerna;

namespace FrancescoZattoni
{
    public class AbstractGameEntity : IGameEntity
    {
        private readonly IPosition _position;

        protected AbstractGameEntity(IPosition position)
        {
            _position = position;
        }

        public IPosition Position => _position;
    }
}