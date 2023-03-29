using beerCreator.Classes.Ingredients.Enums;

namespace beerCreator.Classes.Ingredients
{
    public class Yeast : Ingredient
    {
        /// <summary>
        /// Флоккуляция
        /// </summary>
        public Flocculation Flocculation { get; set; }
        /// <summary>
        /// Толерантность к алкоголю
        /// </summary>
        public int AlcoholTolerance { get; set; }
    }
}
