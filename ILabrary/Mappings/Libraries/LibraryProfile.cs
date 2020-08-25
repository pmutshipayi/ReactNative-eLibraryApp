using AutoMapper;
using ILabrary.Models.Libraries;
using ILabrary.ModelViews.Libraries;

namespace ILabrary.Mappings.Libraries
{
    public class LibraryProfile : Profile
    {
        public LibraryProfile()
        {
            CreateMap<LibraryCreateViewModel, Library>();
            CreateMap<LibraryCreateViewModel, LibraryUser>();
            CreateMap<LibraryViewModel, Library>().ReverseMap();
        }
    }
}
