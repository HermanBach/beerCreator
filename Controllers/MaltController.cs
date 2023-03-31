using Microsoft.AspNetCore.Mvc;
using beerCreator.Classes.Ingredients;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace beerCreator.Controllers
{
    [Route("api/malt/[controller]")]
    [ApiController]
    public class MaltController : ControllerBase
    {
        [HttpGet("GetAllMalts")]
        public List<Malt> GetAllMalts()
        {
            Malt[] result = new Malt[0];
            return result;
        }

        [HttpGet("GetMaltById")]
        public Malt GetMaltById( int id)
        {
            Malt result = new Malt();
            return result;
        }

        [HttpPost("CreaneNewMalt")]
        public void CreaneNewMalt(Malt malt)
        {

        }

        [HttpPost("EditMalt")]
        public void EditMalt(Malt malt)
        {

        }
        [HttpDelete("DeleteMalt")]
        public void DeleteMalt(int id)
        {

        }
    }
}
