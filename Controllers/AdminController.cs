using Microsoft.AspNetCore.Mvc;
using beerCreator.Models;


namespace beerCreator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        readonly MaltRepository maltRepo = new(new Program().GetConnectionString());
        readonly HopRepository hopRepo = new(new Program().GetConnectionString());

        [HttpGet("CreateTables")]
        public void GetAllMalts()
        {
            maltRepo.CteateNewTable();
            hopRepo.CteateNewTable();
        }

    }
}
