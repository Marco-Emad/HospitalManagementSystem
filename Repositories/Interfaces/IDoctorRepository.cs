using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Repositories.Interfaces
{
    public interface IDoctorRepository : IGenericRepository<Doctor>
    {
        Task<IEnumerable<Doctor>> GetDoctorsWithSpecialtyAsync(string specialty);
    }
}
