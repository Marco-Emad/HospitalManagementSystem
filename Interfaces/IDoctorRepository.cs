using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Interfaces
{
    public interface IDoctorRepository : IRepository<Doctor>
    {
        Task<IEnumerable<Doctor>> GetDoctorsWithSpecialtyAsync(string specialty);
    }
}
