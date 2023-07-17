using beerCreator.Classes.Ingredients;

namespace beerCreator.Models
{
    public interface IAromaticRepository
    {
        List<Aromatic> GetAllAromatic();
        Aromatic GetAromaticById(long Id);
        void CreateNewAromatic(Aromatic aromatic);
        void EditAromatic(Aromatic aromatic);
        void DeleteAromatic(long Id);
        void CteateNewTable();
    }
}
