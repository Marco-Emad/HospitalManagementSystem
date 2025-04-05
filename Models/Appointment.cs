using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Patient))]
        public int PatientId { get; set; }

        [ForeignKey(nameof(Doctor))]
        public int DoctorId { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public DateTime Date { get; set; }

        // Navigation Properties
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public ICollection<Prescription>? Prescription { get; set; }
        public Bill? Bill { get; set; }
    }
}
