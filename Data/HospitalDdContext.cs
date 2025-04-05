using HospitalManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Data
{
    public class HospitalDdContext : DbContext
    {
        public HospitalDdContext(DbContextOptions<HospitalDdContext> options) : base(options) { }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillItem> BillItems { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
    }
}