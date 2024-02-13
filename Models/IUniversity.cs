namespace University.Models
{
    public interface IUniversity
    {
        IEnumerable<Students> GetStudentDetails();
        IEnumerable<Response> AssignRooms(Request req);

    }
}
