using AutoMapper;
using PlatformService.Models;
using PlatformServices.DbContextOptions;

namespace PlatformServices.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // Source - > Target
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}