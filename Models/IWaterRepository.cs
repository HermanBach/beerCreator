using beerCreator.Classes.Ingredients;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

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
    public class WaterRepository : IWaterRepository
    {
        string? connectionString = null;
        public WaterRepository(string conStr)
        {
            connectionString = conStr;
        }
        public List<Water> GetAllWater()
        {
            string sqlQuery = "SELECT * FROM Water";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Water>(sqlQuery).ToList();
            }
        }

        public Water GetWaterById(long Id)
        {
            string sqlQuery = "SELECT * FROM Water WHERE Id = @Id";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query(sqlQuery, new { Id }).FirstOrDefault();
            }
        }
        public void CreateNewWater(Water water)
        {
            string sqlQuery =
                "INSERT INTO Water (Name, Description, Ca, Mg, Na, Sulfates, Bicarbonates)" +
                "VALUES (@Name, @Description, @Ca, @Mg, @Na, @Sulfates, @Bicarbonates)";

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery, water);

            }
        }
        public void EditWater(Water water)
        {
            string sqlQuery =
                "UPDATE Water " +
                "SET Name = @Name, " +
                "Description = @Description, " +
                "Ca = @Ca" +
                "Mg = @Mg" +
                "Na = @Na" +
                "Sulfates = @Sulfates" +
                "Bicarbonates = @Bicarbonates" +
                "WHERE Id = @Id";

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery, water);
            }

        }
        public void DeleteWater(long Id)
        {
            string sqlQuery =
                "DELETE FROM Water " +
                "WHERE Id = @Id";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery, new { Id });
            }
        }
        public void CteateNewTable()
        {
            string sqlQuery =
                "CREATE TABLE Water(" +
                "Id bigint IDENTITY(1, 1) PRIMARY KEY," +
                "Name varchar(255) NOT NULL," +
                "Description varchar(500)," +
                "Ca, Mg, Na, Sulfates, Bicarbonates FLOAT" +
                ");";

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery);
            }
        }
    }
}
