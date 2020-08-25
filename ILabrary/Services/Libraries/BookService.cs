using AutoMapper;
using ILabrary.Data;
using ILabrary.Models.Libraries;
using ILabrary.ModelViews.Libraries;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ILabrary.Services.Libraries
{
    public class BookService : IBookService
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;

        public BookService(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="libraryId"></param>
        /// <returns></returns>
        public IList<BookViewModel> GetAll(int libraryId)
        {
            var books = _db.Books
                .Include(x => x.Images)
                .Where(x => x.LibraryId == libraryId)
                .ToList();
            return _mapper.Map<List<BookViewModel>>(books);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Book> GetAsync(int id)
        {
            var book = await _db.Books
                .Include(x => x.Images)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (book == null)
                return null;
            return book;
        }
    }
}
