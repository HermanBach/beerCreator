using Dapper;
using beerCreator.Classes.Ingredients;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;


namespace beerCreator.Models
{
    public interface IHopRepository
    {
        List<Hop> GetAllHops();
        Hop GetHopById(long Id);
        void CreaneNewHop(Hop hop);
        void EditHop(Hop hop);
        void DeleteHop(long Id);
        void CteateNewTable();
    }

    public class HopRepository : IHopRepository
    {
        string? connectionString = null;
        public HopRepository(string conStr)
        {
            connectionString = conStr;
        }
        public List<Hop> GetAllHops()
        {
            string sqlQuery = "SELECT * FROM Hops";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Hop>(sqlQuery).ToList();
            }
        }

        public Hop GetHopById(long Id)
        {
            string sqlQuery = "SELECT * FROM Hops WHERE Id = @Id";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query(sqlQuery, new { Id }).FirstOrDefault();
            }
        }
        public void CreaneNewHop(Hop hop)
        {
            string sqlQuery =
                "INSERT INTO Malt (Name, Description, AlphaAcid, HopType)" +
                "VALUES ({ @Name }, { @Description }, { @AlphaAcid }, { @HopType })";

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery, hop);

            }
        }
        public void EditHop(Hop hop)
        {
            string sqlQuery =
                "UPDATE Malt " +
                "SET Name = @Name, " +
                "Description = @Description, " +
                "AlphaAcid = @AlphaAcid, " +
                "HopType = @HopType" +
                "WHERE Id = @Id";

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery, hop);
            }

        }
        public void DeleteHop(long Id)
        {
            string sqlQuery =
                "DELETE FROM Hop " +
                "WHERE Id = @Id";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery, new { Id });
            }
        }
        public void CteateNewTable()
        {
            string sqlQuery =
                "CREATE TABLE Hops(" +
                "Id bigint IDENTITY(1, 1) PRIMARY KEY," +
                "Name varchar(255) NOT NULL," +
                "Description varchar(500)," +
                "AlphaAcid float," +
                "HopType int" +
                ");";

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute(sqlQuery);
            }
        }
    }
}