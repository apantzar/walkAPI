using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace walkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentsNames = new string[] { "John", "Jane", "Mark", "David" };
            return Ok(studentsNames);
        }
    }
}
