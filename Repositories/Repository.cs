using HospitalManagementSystem.Data;
using HospitalManagementSystem.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly HospitalDdContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(HospitalDdContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<T> GetByIdAsync(int id) => await _dbSet.FindAsync(id);

        public async Task<IEnumerable<T>> GetAllAsync() => await _dbSet.ToListAsync();

        public async Task AddAsync(T entity) => await _dbSet.AddAsync(entity);

        public void UpdateAsync(T entity) => _dbSet.Update(entity);

        public void DeleteAsync(T entity) => _dbSet.Remove(entity);

        public async Task SaveAsync() => await _context.SaveChangesAsync();
    }
}
