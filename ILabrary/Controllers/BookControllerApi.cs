using AutoMapper;
using ILabrary.Core;
using ILabrary.Data;
using ILabrary.Models.Libraries;
using ILabrary.ModelViews.Libraries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ILabrary.Controllers
{
    [ApiController]
    [Route("api/book/")]
    public class BookControllerApi : Controller
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;

        public BookControllerApi(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        private IList<Book> Prepare(IList<Book> books)
        {
            foreach (var book in books)
            {
                int qtyAvailable = book.Qty - book.Allocations.Count(x => x.Allocation.DateReturned == null);
                book.IsAvailable = book.AllowOnlineReservation && qtyAvailable > 0;
                book.QtyAvailable = qtyAvailable;
            }
            return books;
        }

        private IQueryable<Book> BaseQuery
        {
            get
            {
                return _db.Books
                .Include(x => x.Tags)
                .Include(x => x.Images)
                .Include(x => x.Library)
                .Include(x => x.Allocations)
                .AsQueryable();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tags"></param>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<IList<BookViewModel>> SearchAsync([FromQuery]BookSearch searchModel)
        {
            var query = _db.Books
                .Include(x => x.Tags)
                .Include(x => x.Images)
                .Include(x => x.Library)
                .Include(x => x.Allocations)
                .AsQueryable();

            // Filter by tags

            if (!searchModel.Tags.IsNullOrEmpty())
                query = query.Where(book => (from tag in searchModel.Tags
                                             select tag.ToLower())
                                       .Any(w => (from bookTag in book.Tags
                                                  select bookTag.Name.ToLower())
                                                 .Contains(w)));

            // Filter by book name

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(book => book.Name.ToLower().Contains(searchModel.Name.ToLower()) || book.Barcode.Equals(searchModel.Name));

            // Filter by library ids

            if (searchModel.LibraryId != null)
            {
                query = query.Where(book => book.LibraryId == searchModel.LibraryId);
            }

            var pageIndex = searchModel.PageIndex > 0 ? searchModel.PageIndex : 1;
            var pageSize = searchModel.PageSize > 1 ? searchModel.PageSize : 1000;
            var skip = (pageIndex - 1) * pageSize;

            // Apply pagination

            var books = await query.Skip(skip).Take(pageSize)
                .ToListAsync();

            Prepare(books);
            return _mapper.Map<IList<BookViewModel>>(books);
        }

        /// <summary>
        /// Get similar book id
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        [HttpGet("similar/{bookId}")]
        public async Task<IList<BookViewModel>> GetSimilarAsync(int bookId, [FromQuery] int pageSize)
        {
            if (pageSize == 0) pageSize = 1000;
            var book = await _db.Books
                .Include(x => x.Tags)
                .FirstOrDefaultAsync(x => x.Id == bookId);
            if (book == null)
                return new List<BookViewModel>();

            var query = _db.Books
                .Include(x => x.Tags)
                .Include(x => x.Images)
                .Include(x => x.Library)
                .Include(x => x.Allocations)
                .AsQueryable();

            var similar = await (from x in BaseQuery
                                 from tag in book.Tags
                                 where !string.IsNullOrWhiteSpace(x.Barcode) && x.Barcode.Equals(book.Barcode) ||
                                       x.Tags.Select(w => w.Name.ToLower()).Contains(tag.Name.ToLower())
                                 select x).Take(pageSize).ToListAsync();
            Prepare(similar);
            return _mapper.Map<IList<BookViewModel>>(similar);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="barcode"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpGet("libraries/{barcode}/{libraryId}")]
        public async Task<IList<LibraryViewModel>> GetFromOthersLibrariesAsync(string barcode, int libraryId, [FromQuery] int pageSize)
        {
            if (pageSize == 0) pageSize = 1000;
            var libraries = await BaseQuery
                .Where(x => !string.IsNullOrWhiteSpace(x.Barcode) && x.Barcode.Equals(barcode) && x.LibraryId != libraryId)
                .GroupBy(x => x.LibraryId)
                .Select(x => x.First())
                .Select(x => x.Library)
                .ToListAsync();
            return _mapper.Map<IList<LibraryViewModel>>(libraries);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class BookSearch
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string Name { get; set; }
        public IList<string> Tags { get; set; }
        public int? LibraryId { get; set; }
    }
}
