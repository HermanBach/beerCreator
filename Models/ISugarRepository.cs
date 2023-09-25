using beerCreator.Classes.Ingredients;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace beerCreator.Models
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
    public class SugarRepository : ISugarRepository
    {
        string? connectionString = null;
        public SugarRepository(string conStr)
        {
            connectionString = conStr;
        }
        public List<Sugar> GetAllSugar()
        {
            string sqlQuery = "SELECT * FROM Sugar";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Sugar>(sqlQuery).ToList();
            }
        }

        public Sugar GetSugarById(long Id)
        {
            string sqlQuery = "SELECT * FROM Sugar WHERE Id = @Id";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Sugar>(sqlQuery, new { Id }).FirstOrDefault();
            }
        }
        public void CreateNewSugar(Sugar sugar)
        {
            string sqlQuery =
                "INSERT INTO Sugar (Name, Description, SugarContent)" +
                "VALUES (@Name, @Description, @SugarContent)";

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery, sugar);

            }
        }
        public void EditSugar(Sugar sugar)
        {
            string sqlQuery =
                "UPDATE Sugar " +
                "SET Name = @Name, " +
                "Description = @Description, " +
                "SugarContent = @SugarContent" +
                "WHERE Id = @Id";

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery, sugar);
            }

        }
        public void DeleteSugar(long Id)
        {
            string sqlQuery =
                "DELETE FROM Sugar " +
                "WHERE Id = @Id";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery, new { Id });
            }
        }
        public void CteateNewTable()
        {
            string sqlQuery =
                "CREATE TABLE Sugar(" +
                "Id bigint IDENTITY(1, 1) PRIMARY KEY," +
                "Name varchar(255) NOT NULL," +
                "Description varchar(500)," +
                "SugarContent float" +
                ");";

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery);
            }
        }
    }
}
