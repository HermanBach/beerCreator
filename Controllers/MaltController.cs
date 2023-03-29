using Microsoft.AspNetCore.Mvc;
using beerCreator.Classes.Ingredients;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace beerCreator.Controllers
{
    [Route("api/malt/[controller]")]
    [ApiController]
    public class MaltController : ControllerBase
    {
        [HttpPost]
        public Malt[] GetAllMalts()
        {
            Malt[] result = new Malt[0];
            return result;
        }

    }
}
