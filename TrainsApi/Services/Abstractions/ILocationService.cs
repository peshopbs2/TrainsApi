using TrainsApi.Data.Entities;
using TrainsApi.DTOs;
using TrainsApi.DTOs.Requests;
using TrainsApi.DTOs.Responses;

namespace TrainsApi.Services.Abstractions
{
    public interface ILocationService
    {
        Task<List<LocationResponseDTO>> GetLocationsAsync();
        Task<LocationResponseDTO> GetLocationByIdAsync(int id);
        Task<LocationResponseDTO> GetLocationByNameAsync(string name);
        Task AddLocationAsync(LocationRequestDTO location);
        Task DeleteLocationByIdAsync(int id);
        Task UpdateLocationAsync(LocationRequestDTO location);
    }
}
