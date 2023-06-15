using AlessandroVerna

namespace FrancescoFilippini

public interface Hitbox
{
    /*
    * The method to get the center of the shape.
    * @return the center of the shape.
    */
    PositionImpl GetCenter();

    /*
    * The method to update the HitBox position.
    * @param center the abscissa and the ordinate of the center of the Hitbox.
    */
    void UpdateHitBox(PositionImpl center);

    double getLeftX();

    double getRightX();

    double getUpperY();

    double getLowerY();
}