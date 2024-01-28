using AutoMapper;
using TrainsApi.Data.Entities;
using TrainsApi.Data.Repositories.Abstractions;
using TrainsApi.DTOs.Requests;
using TrainsApi.DTOs.Responses;
using TrainsApi.Services.Abstractions;

namespace TrainsApi.Services
{
    public class LocationService : ILocationService
    {
        private readonly IRepository<Location> _repository;
        private readonly IMapper _mapper;
        public LocationService(IRepository<Location> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task AddLocationAsync(LocationRequestDTO location)
        {
            var entity = _mapper.Map<Location>(location);
            return _repository.AddAsync(entity);
        }

        public Task DeleteLocationByIdAsync(int id)
        {
            return _repository.DeleteByIdAsync(id);
        }

        public async Task<LocationResponseDTO> GetLocationByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return _mapper.Map<LocationResponseDTO>(entity);
        }

        public async Task<LocationResponseDTO> GetLocationByNameAsync(string name)
        {
            var entity = (await _repository
                    .GetAsync(item => item.Name == name)
                   )
                   .FirstOrDefault();
            return _mapper.Map<LocationResponseDTO>(entity);
        }

        public async Task<List<LocationResponseDTO>> GetLocationsAsync()
        {
            var list = (await _repository.GetAllAsync())
                .ToList();
            return _mapper.Map<List<LocationResponseDTO>>(list);
        }

        public Task UpdateLocationAsync(LocationRequestDTO location)
        {
            var entity = _mapper.Map<Location>(location);
            return _repository.UpdateAsync(entity);
        }
    }
}
