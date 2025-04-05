using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class MedicalRecord
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Patient))]
        public int PatientId { get; set; }

        [Required]
        public string Diagnosis { get; set; }

        [Required]
        public DateOnly Date { get; set; }

        // Navigation Properties
        public Patient Patient { get; set; }
    }
}
