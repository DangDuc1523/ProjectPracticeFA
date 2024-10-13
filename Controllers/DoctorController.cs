using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthcareAppointment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly string connectionString;

        public DoctorController(IConfiguration configuration)
        {
            connectionString = configuration["ConnectionStrings:DbConneted"] ?? "";
        }

        [HttpGet]
        public IActionResult GetDoctor()
        {
            return Ok();
        }


        [HttpGet("{id}")]

        public IActionResult GetDoctorById(int id)
        {
                return Ok();
        }

        [HttpPost]
        public IActionResult PostDoctor()
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult PutDoctor()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteDoctor()
        {
            return Ok();
        }

    }
}
