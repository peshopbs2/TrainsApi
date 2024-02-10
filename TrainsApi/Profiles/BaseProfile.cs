using AutoMapper;
using TrainsApi.Data.Entities;
using TrainsApi.DTOs.Abstractions;
using TrainsApi.DTOs.Requests;
using TrainsApi.DTOs.Responses;

namespace TrainsApi.Profiles
{
    public class BaseProfile : Profile
    {
        public BaseProfile()
        {
            CreateMap<BaseEntity, BaseResponseDTO>();
            CreateMap<BaseRequestDTO, BaseEntity>();
        }
    }
}
