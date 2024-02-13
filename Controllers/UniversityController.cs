using Microsoft.AspNetCore.Mvc;
using University.Models;

namespace University.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UniversityController : ControllerBase
    {
        private readonly IUniversity _university;
        public UniversityController(IUniversity university)
        {
            _university = university;
        }

        [HttpGet(Name = "GetStudent")]
        public IEnumerable<Students> GetStudents()
        {
           return _university.GetStudentDetails();

        }

        [HttpPost(Name = "AssignRooms")]
        public IEnumerable<Response> AssignRooms(Request req)
        {
            return _university.AssignRooms(req);

        }
    }
}
