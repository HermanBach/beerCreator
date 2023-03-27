using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace beerCreator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaltController : ControllerBase
    {
        // GET: api/<MaltController>
        [HttpGet]
        public string Get()
        {
            return "Ok";
        }

    }
}
