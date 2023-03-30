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

        [HttpPost]
        public Malt GetMaltById( int id)
        {
            Malt result = new Malt();
            return result;
        }

        [HttpPost]
        public void CreaneNewMalt(Malt malt)
        {
            Malt[] result = new Malt[0];
        }

        [HttpPost]
        public void EditMalt(Malt malt)
        {
            Malt[] result = new Malt[0];
        }
        [HttpPost]
        public void DeleteMalt(int id)
        {
            Malt[] result = new Malt[0];
        }
    }
}
