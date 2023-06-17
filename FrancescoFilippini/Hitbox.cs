using AlessandroVerna;

namespace FrancescoFilippini
{
public interface IHitbox
{
    /*
    * The method to get the center of the shape.
    * @return the center of the shape.
    */
    IPosition Center{ get; }

    /*
    * The method to update the HitBox position.
    * @param center the abscissa and the ordinate of the center of the Hitbox.
    */
    void UpdateHitBox(IPosition center);

    double LeftX{ get; }

    double RightX{ get; }

    double UpperY{ get; }

    double LowerY{ get; }
}
}