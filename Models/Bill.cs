using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Bill
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Patient))]
        public int PatientId { get; set; }

        [ForeignKey(nameof(Appointment))]
        public int AppointmentId { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public DateTime Date { get; set; }

        // Navigation Properties
        public Appointment Appointment { get; set; }
        public Patient Patient { get; set; }
        public ICollection<BillItem>? BillItems { get; set; }

    }
}
