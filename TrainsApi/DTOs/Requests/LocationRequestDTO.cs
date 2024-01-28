using TrainsApi.DTOs.Abstractions;

namespace TrainsApi.DTOs.Requests
{
    public class LocationRequestDTO : BaseRequestDTO
    {
        public string Name { get; set; }
    }
}
