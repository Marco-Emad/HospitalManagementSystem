using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Services.Interfaces
{
    public interface IDoctorService : IGenericService<Doctor>
    {
        Task<IEnumerable<Doctor>> GetDoctorsBySpecializationAsync(string specialization);
    }

}
