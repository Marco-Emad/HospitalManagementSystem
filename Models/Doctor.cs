using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Specialization { get; set; }

        // Navigation Properties
        public ICollection<Appointment>? Appointments { get; set; }
    }
}