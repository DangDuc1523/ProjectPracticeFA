using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthcareAppointment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {

        private readonly string connectionString;

        public AppointmentController(IConfiguration configuration)
        {
            connectionString = configuration["ConnectionStrings:DbConneted"] ?? "";
        }

        [HttpGet]
        public IActionResult GetAppointment()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetAppointmentById()
        {
            return BadRequest();
        }


        [HttpPost]
        public IActionResult PostAppoinment()
        {
            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult PutAppoinment()
        {
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAppoinment()
        {

            return BadRequest();
        }

        [HttpPatch("{id}")]
        public void PatchAppoinment()
        {
            return;
        }

        [HttpGet("{doctorId}")]
        public IActionResult GetAppoinment()
        {

            return Ok();

        }
    }
}
