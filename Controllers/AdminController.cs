using Microsoft.AspNetCore.Mvc;
using beerCreator.Models;


namespace beerCreator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
            //TODO: вынести ConnectionString в appsettings.json
        readonly MaltRepository maltRepo = new(
            "data source = localhost; " +
            "initial catalog = BC; " +
            "persist security info=True; " +
            "Integrated Security = SSPI; " +
            "MultipleActiveResultSets = True; " +
            "TrustServerCertificate = true;");
        
        readonly HopRepository hopRepo = new("data source = localhost; " +
            "initial catalog = BC; " +
            "persist security info=True; " +
            "Integrated Security = SSPI; " +
            "MultipleActiveResultSets = True; " +
            "TrustServerCertificate = true;");

        [HttpGet("CreateTables")]
        public void GetAllMalts()
        {
            maltRepo.CteateNewTable();
            hopRepo.CteateNewTable();
        }

    }
}
