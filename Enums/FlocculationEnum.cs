using System.ComponentModel;

namespace beerCreator.Enums
{
    public enum Flocculation
    {
        [Description("Низкая")]
        Low = 1,
        [Description("Средняя")]
        Midddle = 2,
        [Description("Высокая")]
        High = 3,
        [Description("Разная")]
        Different = 4
    }
}
