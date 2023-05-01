using beerCreator.Enums;

namespace beerCreator.Classes.Ingredients
{
    public class Hop : Ingredient
    {
        /// <summary>
        /// Альфа-кислотность
        /// </summary>
        public double AlphaAcid { get; set; }
        /// <summary>
        /// Тип хмеля
        /// </summary>
        public HopType HopType { get; set; }
    }
}
