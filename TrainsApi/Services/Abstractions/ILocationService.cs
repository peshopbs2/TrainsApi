using TrainsApi.Data.Entities;

namespace TrainsApi.Services.Abstractions
{
    public interface ILocationService
    {
        Task<List<Location>> GetLocationsAsync();
        Task<Location> GetLocationByIdAsync(int id);
        Task<Location> GetLocationByNameAsync(string name);
        Task AddLocationAsync(Location location);
        Task DeleteLocationByIdAsync(int id);
        Task UpdateLocationAsync(Location location);
    }
}
