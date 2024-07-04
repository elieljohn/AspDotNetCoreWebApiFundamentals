using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet()]
        public JsonResult GetCities()
        {
            return new JsonResult(
                new List<object>
                {
                    new { id = 1, Name = "New York City" },
                    new { id = 2, Name = "Antwerp" }
                });
        }
    }
}
