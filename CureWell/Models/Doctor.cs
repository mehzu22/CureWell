using System.ComponentModel.DataAnnotations;

namespace CureWell.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        public string? DoctorName { get; set; }
        public bool IsActive { get; set; }
 
    }
}