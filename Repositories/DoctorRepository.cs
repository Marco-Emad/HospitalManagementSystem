using HospitalManagementSystem.Data;
using HospitalManagementSystem.Interfaces;
using HospitalManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Repositories
{
    public class DoctorRepository : Repository<Doctor>, IDoctorRepository
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
