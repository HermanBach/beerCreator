using beerCreator.Classes.Ingredients;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

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
    public class AromaticRepository : IAromaticRepository
    {
        string? connectionString = null;
        public AromaticRepository(string conStr)
        {
            connectionString = conStr;
        }
        public List<Aromatic> GetAllAromatic()
        {
            string sqlQuery = "SELECT * FROM Aromatic";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Aromatic>(sqlQuery).ToList();
            }
        }

        public Aromatic GetAromaticById(long Id)
        {
            string sqlQuery = "SELECT * FROM Aromatic WHERE Id = @Id";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query(sqlQuery, new { Id }).FirstOrDefault();
            }
        }
        public void CreateNewAromatic(Aromatic aromatic)
        {
            string sqlQuery =
                "INSERT INTO Aromatic (Name, Description, AlphaAcid, HopType)" +
                "VALUES (@Name, @Description)";

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery, aromatic);

            }
        }
        public void EditAromatic(Aromatic aromatic)
        {
            string sqlQuery =
                "UPDATE Aromatic " +
                "SET Name = @Name, " +
                "Description = @Description, " +
                "WHERE Id = @Id";

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery, aromatic);
            }

        }
        public void DeleteAromatic(long Id)
        {
            string sqlQuery =
                "DELETE FROM Aromatic " +
                "WHERE Id = @Id";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery, new { Id });
            }
        }
        public void CteateNewTable()
        {
            string sqlQuery =
                "CREATE TABLE Aromatic(" +
                "Id bigint IDENTITY(1, 1) PRIMARY KEY," +
                "Name varchar(255) NOT NULL," +
                "Description varchar(500)," +
                ");";

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery);
            }
        }
    }
}
