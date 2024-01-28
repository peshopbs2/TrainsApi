using TrainsApi.DTOs.Abstractions;

namespace TrainsApi.DTOs.Requests
{
    public class EmployeeRequestDTO
        : BaseRequestDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
    }
}
