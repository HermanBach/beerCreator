namespace beerCreator.Classes
{
    public abstract class Ingredient
    {
        /// <summary>
        /// Id ингредиента
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Название ингредиента
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание ингредиента
        /// </summary>
        public string Description { get; set; }
    }
}
