namespace beerCreator.Classes.Ingredients
{
    public class Malt : Ingredient
    {
        /// <summary>
        /// Цветность солода European Brewing Convention
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Экстракт на с.в. солода
        /// </summary>
        public double Extract { get; set; }
        
    }
}
