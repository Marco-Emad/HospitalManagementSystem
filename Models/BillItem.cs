using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class BillItem
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Bill))]
        public int BillingId { get; set; }

        [ForeignKey(nameof(Inventory))]
        public int ItemId { get; set; }

        [Required]
        public int Qunatity { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        // Navigation Properties
        public Bill Bill { get; set; }
        public Inventory Inventory { get; set; }
    }
}
