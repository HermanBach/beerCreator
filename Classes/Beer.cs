namespace beerCreator.Classes
{
    public class Beer
    {
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
