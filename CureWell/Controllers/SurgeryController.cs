using CureWell.Models;
using CureWell.Services;
using Microsoft.AspNetCore.Mvc;

namespace CureWell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurgeryController : ControllerBase
    {
        private readonly ISurgeryService _surgeryService;

        public SurgeryController(ISurgeryService surgeryService)
        {
            _surgeryService = surgeryService;
        }

        [HttpGet("GetAllSurgeryForToday")]
        public ActionResult<List<Surgery>> GetAllSurgeryTypeForToday()
        {
            try
            {
                var listOfAllSurgery = _surgeryService.GetAllSurgeryTypeForToday();
                return listOfAllSurgery;
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }


        [HttpPut("UpdateSurgery")]
        public IActionResult UpdateSurgery(Surgery surgery)
        {
            try
            {
                if (_surgeryService.UpdateSurgery(surgery))
                    return Ok("Surgery updated successfully!");
                else
                    return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occur while updating surgery details.");
            }
        }
    }
}