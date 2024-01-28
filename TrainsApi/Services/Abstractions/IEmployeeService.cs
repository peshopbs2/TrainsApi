using TrainsApi.DTOs.Requests;
using TrainsApi.DTOs.Responses;

namespace TrainsApi.Services.Abstractions
{
    public interface IEmployeeService
    {
        Task<List<EmployeeResponseDTO>> GetEmployeesAsync();
        Task<EmployeeResponseDTO> GetEmployeeByIdAsync(int id);
        Task<List<EmployeeResponseDTO>> GetEmployeesByJobTitleAsync(string jobTitle);
        Task AddEmployeeAsync(EmployeeRequestDTO employee);
        Task DeleteEmployeeByIdAsync(int id);
        Task UpdateEmployeeAsync(EmployeeRequestDTO employee);

    }
}
