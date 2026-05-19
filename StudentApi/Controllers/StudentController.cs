using Microsoft.AspNetCore.Mvc;

namespace StudentApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var student = new
            {
                StudentNumber = "B211200565", 
                FirstName = "Abdullah",
                LastName = "Garibov"
            };

            return Ok(student);
        }
    }
}