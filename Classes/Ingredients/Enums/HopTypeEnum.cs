using System.ComponentModel;

namespace beerCreator.Classes.Ingredients.Enums
{
    public enum HopType
    {
        [Description("Гранулы")]
        Granules = 1,
        [Description("Шишки")]
        Cones = 2,
        [Description("Брикеты")]
        Briquettes = 3,
        [Description("Лупулин")]
        Lupulin = 4
    }
}
