using HealthcareAppointment.WebAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace HealthcareAppointment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly string connectionString;
        public PatientController(IConfiguration configuration) {
            connectionString = configuration["ConnectionStrings:DbConneted"] ?? "";
        }

        [HttpGet]
        public IActionResult GetPatient()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetPatientById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreatePatient(User user)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "Insert into Users\r\n(Name,Email,DateOfBirth,Password,Role,Specialization ) \r\nValues (@Name, @Email, @DateOfBirth, @Password, @Role, @Specialization)";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", user.Name);
                        command.Parameters.AddWithValue("@Email", user.Email);
                        command.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);
                        command.Parameters.AddWithValue("@Password", user.Password);
                        command.Parameters.AddWithValue("@Role", user.Role);
                        command.Parameters.AddWithValue("@Specialization", user.Specialization);

                        command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult PutPatient(User user)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePatient(int id)
        {

            return Ok();
        }
     
    }
}
