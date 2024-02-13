using System.ComponentModel.DataAnnotations;

namespace University.Models
{
    public class Response
    {
        [Key]
        public int AssignedStatus { get; set; }
        public string Msg { get; set; }
        public int RoomId { get; set; }
        public int HallId { get; set; }
        public int RoomNo { get; set; }

    }
}
