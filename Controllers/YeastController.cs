using Microsoft.AspNetCore.Mvc;
using beerCreator.Classes.Ingredients;
using beerCreator.Models;

namespace beerCreator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YeastController : ControllerBase
    {

        readonly YeastRepository rep = new("data source = localhost; initial catalog = BC; persist security info=True; Integrated Security = SSPI; MultipleActiveResultSets = True; TrustServerCertificate = true;");

        [HttpGet("GetAllYeasts")]
        public List<Yeast> GetAllYeasts()
        {
            return rep.GetAllYeasts();
        }

        [HttpGet("GetYeastById")]
        public Yeast GetYeastById(int id)
        {
            return rep.GetYeastById(id);
        }

        [HttpPost("CreateNewYeast")]
        public void CreaneNewYeast(Yeast yeast)
        {
            rep.CreaneNewYeast(yeast);
        }

        [HttpPost("EditYeast")]
        public void EditMalt(Yeast yeast)
        {
            rep.EditYeast(yeast);
        }

        [HttpDelete("DeleteYeast")]
        public void DeleteYeast(int id)
        {
            rep.DeleteYeast(id);
        }
    }
}
