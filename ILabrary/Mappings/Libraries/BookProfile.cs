using AutoMapper;
using ILabrary.Models.Libraries;
using ILabrary.ModelViews.Libraries;

namespace ILabrary.Mappings.Libraries
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<BookCreateViewModel, Book>();
            CreateMap<BookPicture, BookPictureViewModel>();
            CreateMap<Book, BookUpdateViewModel>().ReverseMap();
            CreateMap<BookTag, BookTagViewModel>();
            CreateMap<BookViewModel, Book>().ReverseMap();
        }
    }
}
