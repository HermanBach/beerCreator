using Dapper;
using beerCreator.Classes.Ingredients;
using System.Data;
using System.Data.SqlClient;

namespace beerCreator.Models
{
    interface IMaltRepository
    {
        List<Malt> GetAllMalts();
        Malt GetMaltById(int Id);
        void CreaneNewMalt(Malt malt);
        void EditMalt(Malt malt);
        void DeleteMalt(int Id);
    }

    public class MaltRepository : IMaltRepository
    {
        string? connectionString = null;
        public MaltRepository (string conStr)
        {
            connectionString = conStr;
        }
        public List<Malt> GetAllMalts()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Malt>("SELECT * FROM Malts").ToList();
            }
        }

        public Malt GetMaltMyId(int Id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Malt>("SELECT * FROM Malt  WHERE Id = @Id", new { id }).FirstOrDefault();
            }

        }
    }
}
