using Microsoft.AspNetCore.Mvc;
using beerCreator.Classes.Ingredients;
using beerCreator.Models;

namespace beerCreator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YeastController : ControllerBase
    {

        readonly YeastRepository rep = new(new Program().GetConnectionString());

        [HttpGet("GetAllYeast")]
        public List<Yeast> GetAllYeast()
        {
            return rep.GetAllYeasts();
        }

        [HttpGet("GetYeastById")]
        public Yeast GetYeastById(int id)
        {
            return rep.GetYeastById(id);
        }

        [HttpPost("CreateNewYeast")]
        public void CreateNewYeast(Yeast yeast)
        {
            rep.CreateNewYeast(yeast);

        }

        [HttpPost("EditYeast")]
        public void EditHop(Yeast yeast)
        {
            rep.EditYeast(yeast);
        }
        [HttpDelete("DeleteYeast")]
        public void DeleteHop(int id)
        {
            rep.DeleteYeast(id);
        }
    }
}
