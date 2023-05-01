using Dapper;
using beerCreator.Classes.Ingredients;
using System.Data;
using Microsoft.Data.SqlClient;


namespace beerCreator.Models
{
    public interface IMaltRepository
    {
        List<Malt> GetAllMalts();
        Malt GetMaltById(long Id);
        void CreaneNewMalt(Malt malt);
        void EditMalt(Malt malt);
        void DeleteMalt(long Id);
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
            string sqlQuery = "SELECT * FROM Malts";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Malt>(sqlQuery).ToList();
            }
        }

        public Malt GetMaltById(long Id)
        {
            string sqlQuery = "SELECT * FROM Malt  WHERE Id = @Id";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Malt>(sqlQuery, Id).FirstOrDefault();
            }

        }
        public void CreaneNewMalt (Malt malt)
        {
            string sqlQuery = 
                "INSERT INTO Malt (Name, Description, Color, Extract)" +
                "VALUES ({ @Name }, { @Description }, { @Color }, { @Extract })";

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query(sqlQuery, malt).FirstOrDefault();

            }
        }
        public void EditMalt (Malt malt)
        {
            string sqlQuery =
                "UPDATE Malt " +
                "SET Name = @Name, " +
                "Description = @Description, " +
                "Color = @Color, " +
                "Extract = @Extract" +
                "WHERE Id = @Id";

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query(sqlQuery, malt).FirstOrDefault();
            }

        }
        public void DeleteMalt (long Id)
        {
            string sqlQuery =
                "DELETE FROM Malt " +
                "WHERE Id = @Id";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query(sqlQuery, Id).FirstOrDefault();
            }

        }
    }
}