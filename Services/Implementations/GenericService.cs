using HospitalManagementSystem.Repositories.Interfaces;
using HospitalManagementSystem.Services.Interfaces;

namespace HospitalManagementSystem.Services.Implementations
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;

        public GenericService(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _repository.GetAllAsync();

        public async Task<T> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);

        public async Task AddAsync(T entity) => await _repository.AddAsync(entity);

        public void Update(T entity) => _repository.Update(entity);

        public void Delete(T entity) => _repository.Delete(entity);
    }

}
