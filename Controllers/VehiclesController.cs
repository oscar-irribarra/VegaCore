using Microsoft.AspNetCore.Mvc;
using VegaCore.Models;

namespace VegaCore.Controllers
{
    [Route("/api/vehicles")]
    public class VehiclesController : Controller
    {
        [HttpPost]
        public IActionResult CreateVehicle([FromBody] Vehicle vehicle)
        {
            return Ok(vehicle);
        }
    }
}