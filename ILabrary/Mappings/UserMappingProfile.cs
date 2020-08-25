using AutoMapper;
using ILabrary.Models;
using ILabrary.ModelViews.Users;

namespace ILabrary.Mappings
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<UserViewModel, User>().ReverseMap();
            CreateMap<UserCreateViewModel, User>().ReverseMap();
        }
    }
}
