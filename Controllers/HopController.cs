using Microsoft.AspNetCore.Mvc;
using beerCreator.Classes.Ingredients;
using beerCreator.Models;

namespace beerCreator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HopController : ControllerBase
    {

        readonly HopRepository rep = new(new Program().GetConnectionString());

        [HttpGet("GetAllHops")]
        public List<Hop> GetAllHops()
        {
            return rep.GetAllHops();
        }

        [HttpGet("GetHopById")]
        public Hop GetHopById(int id)
        {
            return rep.GetHopById(id);
        }

        [HttpPost("CreateNewHop")]
        public void CreateNewHop(Hop hop)
        {
            rep.CreateNewHop(hop);

        }

        [HttpPost("EditHop")]
        public void EditHop(Hop hop)
        {
            rep.EditHop(hop);
        }
        [HttpDelete("DeleteHop")]
        public void DeleteHop(int id)
        {
            rep.DeleteHop(id);
        }
    }
}
