using TrainsApi.DTOs.Abstractions;

namespace TrainsApi.DTOs.Responses
{
    public class EmployeeResponseDTO : BaseResponseDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
    }
}
