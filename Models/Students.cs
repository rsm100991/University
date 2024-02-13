using System.ComponentModel.DataAnnotations;

namespace University.Models
{
    public class Students
    {
      
        [Key]
        public string StudentId { get; set; }
        public string RoomMateId { get; set; }
        public string ResHallName { get; set; }
        public string RoomNo { get; set; }
        public string Bed1 { get; set; }
        public string Bed2 { get; set; }


    }
}
