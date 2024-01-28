using AutoMapper;
using TrainsApi.Data.Entities;
using TrainsApi.Data.Repositories.Abstractions;
using TrainsApi.DTOs.Requests;
using TrainsApi.DTOs.Responses;
using TrainsApi.Services.Abstractions;

namespace TrainsApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> _repository;
        private readonly IMapper _mapper;

        public EmployeeService(IRepository<Employee> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task AddEmployeeAsync(EmployeeRequestDTO employee)
        {
            var entity = _mapper.Map<Employee>(employee);

            return _repository.AddAsync(entity);
        }

        public Task DeleteEmployeeByIdAsync(int id)
        {
            return _repository.DeleteByIdAsync(id);
        }

        public async Task<EmployeeResponseDTO> GetEmployeeByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return _mapper.Map<EmployeeResponseDTO>(entity);
        }

        public async Task<List<EmployeeResponseDTO>> GetEmployeesAsync()
        {
            var list = await _repository.GetAllAsync();
            return _mapper.Map<List<EmployeeResponseDTO>>(list);
        }

        public async Task<List<EmployeeResponseDTO>> GetEmployeesByJobTitleAsync(string jobTitle)
        {
            var list = await _repository.GetAsync(item => item.JobTitle == jobTitle);
            return _mapper.Map<List<EmployeeResponseDTO>>(list);
        }

        public Task UpdateEmployeeAsync(EmployeeRequestDTO employee)
        {
            var entity = _mapper.Map<Employee>(employee);
            return _repository.UpdateAsync(entity);
        }
    }
}
