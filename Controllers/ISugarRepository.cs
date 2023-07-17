using beerCreator.Classes.Ingredients;

namespace beerCreator.Controllers
{
    public interface ISugarRepository
    {
        List<Sugar> GetAllSugar();
        Sugar GetSugarById(long Id);
        void CreateNewSugar(Sugar sugar);
        void EditSugar(Sugar sugar);
        void DeleteSugar(long Id);
        void CteateNewTable();
    }
}
