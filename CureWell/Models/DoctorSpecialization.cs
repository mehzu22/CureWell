using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CureWell.Models
{
    public class DoctorSpecialization
    {
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("Specialization")]
        public string? SpecializationCode { get; set; }

        public DateTime SpecializationDate { get; set; }
        public bool IsActive { get; set; }
 
    }
}