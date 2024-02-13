using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace University.Models
{
    public class UniversityRespository : IUniversity
    {
        private List<Students> _students;
        private readonly AppDbContext _appDbContext;
        public UniversityRespository(AppDbContext context)
        {
            this._appDbContext = context;
        }
        public IEnumerable<Students> GetStudentDetails()
        {
            return _appDbContext.Students.FromSqlRaw("GetStudentDetails").ToList();
        }


        public IEnumerable<Response> AssignRooms(Request req)
        {
            return _appDbContext.AssignRooms.FromSqlRaw($"AssignRoom '{req.StudentID}','{req.RoomMateID}','{req.Gender}','{req.EmailAddress}','{req.RoomTypePreference}'  ").ToList();

        }
    }
}
