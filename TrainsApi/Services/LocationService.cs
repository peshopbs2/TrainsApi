using TrainsApi.Data.Entities;
using TrainsApi.Data.Repositories.Abstractions;
using TrainsApi.Services.Abstractions;

namespace TrainsApi.Services
{
    public class LocationService : ILocationService
    {
        private readonly IRepository<Location> _repository;
        public LocationService(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public Task AddLocationAsync(Location location)
        {
            return _repository.AddAsync(location);
        }

        public Task DeleteLocationByIdAsync(int id)
        {
            return _repository.DeleteByIdAsync(id);
        }

        public Task<Location> GetLocationByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public async Task<Location> GetLocationByNameAsync(string name)
        {
            return (await _repository
                    .GetAsync(item => item.Name == name)
                   )
                   .FirstOrDefault();
        }

        public async Task<List<Location>> GetLocationsAsync()
        {
            return (await _repository.GetAllAsync())
                .ToList();
        }

        public Task UpdateLocationAsync(Location location)
        {
            return _repository.UpdateAsync(location);
        }
    }
}
