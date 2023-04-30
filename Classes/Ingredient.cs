namespace beerCreator.Classes
{
    public abstract class Ingredient
    {
        /// <summary>
        /// Id ингредиента
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Название ингредиента
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание ингредиента
        /// </summary>
        public string? Description { get; set; }

    }
}
