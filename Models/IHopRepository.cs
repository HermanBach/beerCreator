using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using beerCreator.Classes.Ingredients;
using Dapper;

namespace beerCreator.Models
{
    interface IHopRepository
    {
        List<Hop> GetAllHops();
        Hop GetHopById(int Id);
        void CreaneNewHop(Hop malt);
        void EditHop(Hop malt);
        void DeleteHop(int Id);
    }
    public class HopRepository : IHopRepository
    {
        string connectionString = null;
        public HopRepository(string conStr)
        {
            connectionString = conStr;
        }
        public List<Hop> GetAllHops()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Malt>("SELECT * FROM Hop").ToList();
            }
        }

        public Malt GetHopById(int Id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Malt>("SELECT * FROM Hops  WHERE Id = @Id", new { id }).FirstOrDefault();
            }
        }
    }
}