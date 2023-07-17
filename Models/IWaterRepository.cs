using beerCreator.Classes.Ingredients;

namespace beerCreator.Models
{
    public interface IWaterRepository
    {
        List<Water> GetAllWater();
        Water GetWaterById(long Id);
        void CreateNewWater(Water water);
        void EditWater(Water water);
        void DeleteWater(long Id);
        void CteateNewTable();
    }
}
