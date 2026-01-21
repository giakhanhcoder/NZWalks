using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    // https://localhost:7200/api/Students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET: https://localhost:7200/api/Students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentNames = ["John", "Jane", "Jack", "Jill"];

            return Ok(studentNames);
        }

    }
}
 