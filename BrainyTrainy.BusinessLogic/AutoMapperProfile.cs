using AutoMapper;
using BrainyTrainy.Domain.Entities;
using BrainyTrainy.Dtos.User;

namespace BrainyTrainy.BusinessLogic
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<PersonInfo, PersonInfoDto>();
        }
    }
}