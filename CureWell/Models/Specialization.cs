using System.ComponentModel.DataAnnotations;

namespace CureWell.Models
{
    public class Specialization
    {
        [Key]
        public string? SpecializationCode { get; set; }
        public string? SpecializationName { get; set; }
        public bool IsActive {get;set;}
    }
}