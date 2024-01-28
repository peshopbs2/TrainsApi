using AutoMapper;
using TrainsApi.Data.Entities;
using TrainsApi.DTOs.Requests;
using TrainsApi.DTOs.Responses;

namespace TrainsApi.Profiles
{
    public class LocationProfile : Profile
    {
        public LocationProfile() {
            CreateMap<Location, LocationResponseDTO>();
            CreateMap<LocationRequestDTO, Location>();
        }
    }
}
