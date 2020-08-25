using AutoMapper;
using ILabrary.Models.Libraries;
using ILabrary.ModelViews.Libraries;

namespace ILabrary.Mappings.Libraries
{
    public class LibraryUserProfile :Profile
    {
        public LibraryUserProfile()
        {
            CreateMap<LibraryUserCreateViewModel, LibraryUser>();
            CreateMap<LibraryUser, LibraryUserViewModel>();
            CreateMap<LibraryUserUpdateViewModel, LibraryUser>().ReverseMap();
        }
    }
}
