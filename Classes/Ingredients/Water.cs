namespace beerCreator.Classes.Ingredients
{
    public class Water : Ingredient
    {
        /// <summary>
        /// Кальций мг/л
        /// </summary>
        public double Ca { get; set; }
        /// <summary>
        /// Магний мг/л
        /// </summary>
        public double Mg { get; set; }
        /// <summary>
        /// Натрий мг/л
        /// </summary>
        public double Na { get; set; }
        /// <summary>
        /// Сульфаты мг/л
        /// </summary>
        public double Sulfates { get; set; }
        /// <summary>
        /// Гидрокарбонаты мг/л
        /// </summary>
        public double Bicarbonates { get; set; }
    }
}
