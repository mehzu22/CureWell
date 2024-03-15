using CureWell.Models;
using CureWell.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
 
namespace CureWell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecializationController : ControllerBase
    {
        private readonly ISpecializationService _specializationService;
 
        public SpecializationController(ISpecializationService specializationService)
        {
            _specializationService = specializationService;
        }
 
        [HttpGet("GetAllSpecialization")]
        public ActionResult<List<Specialization>> GetAllSpecializations()
        {
            try
            {
            var listOfSpecialization = _specializationService.GetAllSpecializations();
            if(listOfSpecialization != null)
                return listOfSpecialization;
            return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(500,"An error occured while rtuening list of specialization.");
            }
        }
    }
}