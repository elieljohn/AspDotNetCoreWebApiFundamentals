using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace CityInfo.API.Controllers
{
    [ApiController]
    public class CitiesController : ControllerBase
    {
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
