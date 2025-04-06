using HospitalManagementSystem.Data;
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Repositories.Implementations
{
    public class DoctorRepository : GenericRepository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(HospitalDdContext context) : base(context) { }

        public async Task<IEnumerable<Doctor>> GetDoctorsWithSpecialtyAsync(string specialty)
        {
            return await _context.Doctors
                .Where(d => d.Specialization == specialty)
                .ToListAsync();
        }
    }
}
