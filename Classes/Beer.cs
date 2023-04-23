namespace beerCreator.Classes
{
    public class Beer
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Стиль Название
        /// </summary>
        public string Style { get; set; }
        /// <summary>
        /// Начальная плотность
        /// </summary>
        public double InitialDensity { get; set; }
        /// <summary>
        /// Конечная плотность
        /// </summary>
        public double FinalDensity { get; set; }
        /// <summary>
        /// Содержание алкоголя
        /// </summary>
        public double Alcohol { get; set; }
        /// <summary>
        /// Горечь в IBU
        /// </summary>
        public double Bitterness { get; set; }
        /// <summary>
        /// Карбонизация грамм на литр
        /// </summary>
        public double Carbon { get; set; }
    }
}
