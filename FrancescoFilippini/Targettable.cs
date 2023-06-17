using FrancescoZattoni;

namespace FrancescoFilippini
{
    public interface ITargettable
    {
        void MarkTarget();

        bool IsTaken{ get; }
    }
}