using CureWell.Models;
using CureWell.Services;
using Microsoft.AspNetCore.Mvc;

namespace CureWell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet("GetAllDoctors")]
        public ActionResult<List<Doctor>> GetAllDoctors()
        {
            try
            {
            var listOfDoctors = _doctorService.GetAllDoctors();
            if (listOfDoctors != null)
                return listOfDoctors;
            return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred Fetching all doctor. ");
            }
        }

        [HttpPost("AddDoctor")]
        public IActionResult AddDoctor(Doctor doctor)
        {
            try
            {
            if (_doctorService.AddDoctor(doctor))
                return Ok("Doctor Added succesfully!");
            else
                return BadRequest("Could not add Doctor.");
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while Adding doctor. ");
            }
        }

        [HttpPut("UpdateDoctor")]
        public IActionResult UpdateDoctorDetails(Doctor doctor)
        {
            try
            {
                if (_doctorService.UpdateDoctorDetails(doctor))
                    return Ok("Doctor Updated successfully!");
                else
                    return BadRequest("Could not update Doctor.");
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while updating details. ");
            }
        }

        [HttpDelete("DeleteDoctor{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            try
            {
            if (_doctorService.DeleteDoctor(id))
                return Ok("Doctor deleted succcessfully!");
            else
                return NotFound("Doctor not found.");
                
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while deleting details. ");
            }
        }

        [HttpGet("specialization/{specializationCode}")]
        public ActionResult<List<DoctorSpecialization>> GetDoctorsBySpecialization(string specializationCode)
        {
            try
            {
                var specialization = _doctorService.GetDoctorsBySpecialization(specializationCode);
                return specialization;
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}