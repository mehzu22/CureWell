using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CureWell.Models
{
    public class Surgery
    {
        [Key]
        public int SurgeryId { get; set; }

        [ForeignKey("Doctor")] 
        public int DoctorId { get; set; }
 
        public DateTime SurgeryDate { get; set; }
 
        [RegularExpression(@"^(?:[01]\d|2[0-3]).[0-5]\d$",
         ErrorMessage = "Invalid time format. Time should be in HH.MM (24-hour) format.")]
        public decimal StartTime { get; set; }
 
        [RegularExpression(@"^(?:[01]\d|2[0-3]).[0-5]\d$",
         ErrorMessage = "Invalid time format. Time should be in HH.MM (24-hour) format.")]
        public decimal EndTime { get; set; }
 
        public string? SurgeryCategory { get; set; }
        public bool IsActive {get;set;}
    }
}