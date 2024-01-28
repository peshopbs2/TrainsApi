using AutoMapper;
using TrainsApi.Data.Entities;
using TrainsApi.DTOs.Requests;
using TrainsApi.DTOs.Responses;

namespace TrainsApi.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeResponseDTO>();
            CreateMap<EmployeeRequestDTO, Employee>();

        }
    }
}
