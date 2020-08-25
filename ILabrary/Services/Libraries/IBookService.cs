using System.Collections.Generic;
using System.Threading.Tasks;
using ILabrary.Models.Libraries;
using ILabrary.ModelViews.Libraries;

namespace ILabrary.Services.Libraries
{
    public interface IBookService
    {
        IList<BookViewModel> GetAll(int libraryId);
        Task<Book> GetAsync(int id);
    }
}