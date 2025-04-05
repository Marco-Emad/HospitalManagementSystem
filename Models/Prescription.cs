using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Prescription
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Appointment))]
        public int AppointmentId { get; set; }

        [Required]
        public string MedicineName { get; set; }

        [Required]
        public int Dosage { get; set; }

        [Required]
        public string Instructions { get; set; }

        // Navigation Properties
        public Appointment Appointment { get; set; }
    }
}
