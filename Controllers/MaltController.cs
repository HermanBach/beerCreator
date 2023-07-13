using Microsoft.AspNetCore.Mvc;
using beerCreator.Classes.Ingredients;
using beerCreator.Models;

namespace beerCreator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaltController : ControllerBase
    {

        readonly MaltRepository rep = new (new Program().GetConnectionString());

        [HttpGet("GetAllMalts")]
        public List<Malt> GetAllMalts()
        {
            return rep.GetAllMalts();
        }

        [HttpGet("GetMaltById")]
        public Malt GetMaltById( int id)
        {
            return rep.GetMaltById(id);
        }

        [HttpPost("CreaneNewMalt")]
        public void CreaneNewMalt(Malt malt)
        {
            rep.CreaneNewMalt(malt);

        }

        [HttpPost("EditMalt")]
        public void EditMalt(Malt malt)
        {
            rep.EditMalt(malt);
        }
        [HttpDelete("DeleteMalt")]
        public void DeleteMalt(int id)
        {
            rep.DeleteMalt(id);
        }
    }
}
