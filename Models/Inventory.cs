using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal PricePerUnit { get; set; }

        // Navigation Properties
        public ICollection<BillItem>? BillItems { get; set; }
    }
}
