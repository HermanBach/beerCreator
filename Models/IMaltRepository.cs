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
        void CreateNewMalt(Malt malt);
        void EditMalt(Malt malt);
        void DeleteMalt(long Id);
        void CteateNewTable ();
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
                return db.Query<Malt>(sqlQuery, new { Id }).FirstOrDefault();
            }

        }
        public void CreateNewMalt (Malt malt)
        {
            string sqlQuery = 
                "INSERT INTO Malts (Name, Description, Color, Extract)" +
                "VALUES (@Name, @Description, @Color, @Extract)";

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery, malt);

            }
        }
        public void EditMalt (Malt malt)
        {
            string sqlQuery =
                "UPDATE Malt " +
                "SET Name = @Name" +
                "Description = @Description" +
                "Color = @Color" +
                "Extract = @Extract" +
                "WHERE Id = @Id";

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery, malt);
            }

        }
        public void DeleteMalt (long Id)
        {
            string sqlQuery =
                "DELETE FROM Malt " +
                "WHERE Id = @Id";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery, new { Id });
            }

        }
        public void CteateNewTable()
        {
            string sqlQuery =
                "CREATE TABLE Malts(" +
                "Id bigint IDENTITY(1, 1) PRIMARY KEY," +
                "Name varchar(255) NOT NULL," +
                "Description varchar(500)," +
                "Color float," +
                "Extract float" +
                ");";

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery);
            }
        }
    }
}