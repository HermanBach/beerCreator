using Dapper;
using beerCreator.Classes.Ingredients;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;


namespace beerCreator.Models
{
    public interface IYeastRepository
    {
        List<Yeast> GetAllYeasts();
        Yeast GetYeastById(long Id);
        void CreaneNewYeast(Yeast yeast);
        void EditYeast(Yeast yeast);
        void DeleteYeast(long Id);
        void CteateNewTable();
    }

    public class YeastRepository : IYeastRepository
    {
        string? connectionString = null;
        public YeastRepository(string conStr)
        {
            connectionString = conStr;
        }
        public List<Yeast> GetAllYeasts()
        {
            string sqlQuery = "SELECT * FROM Yeasts";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Yeast>(sqlQuery).ToList();
            }
        }

        public Yeast GetYeastById(long Id)
        {
            string sqlQuery = "SELECT * FROM Yeasts WHERE Id = @Id";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Yeast>(sqlQuery, new { Id }).FirstOrDefault();
            }
        }
        public void CreaneNewYeast(Yeast yeast)
        {
            string sqlQuery =
                "INSERT INTO Yeasts (Name, Description, Flocculation, AlcoholTolerance)" +
                "VALUES (@Name, @Description, @Flocculation, @AlcoholTolerance)";

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery, yeast);

            }
        }
        public void EditYeast(Yeast yeast)
        {
            string sqlQuery =
                "UPDATE Yeasts " +
                "SET Name = @Name, " +
                "Description = @Description, " +
                "Flocculation = @Flocculation, " +
                "AlcoholTolerance = @AlcoholTolerance" +
                "WHERE Id = @Id";

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery, yeast);
            }

        }
        public void DeleteYeast(long Id)
        {
            string sqlQuery =
                "DELETE FROM Yeasts " +
                "WHERE Id = @Id";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery, new { Id });
            }
        }
        public void CteateNewTable()
        {
            string sqlQuery =
                "CREATE TABLE Yeasts(" +
                "Id bigint IDENTITY(1, 1) PRIMARY KEY," +
                "Name varchar(255) NOT NULL," +
                "Description varchar(500)," +
                "Flocculation int," +
                "AlcoholTolerance float" +
                ");";

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery);
            }
        }
    }
}