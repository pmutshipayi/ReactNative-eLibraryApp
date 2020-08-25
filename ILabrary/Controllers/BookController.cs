using AutoMapper;
using ILabrary.Data;
using ILabrary.Models.Libraries;
using ILabrary.ModelViews.Libraries;
using ILabrary.Services;
using ILabrary.Services.Libraries;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace ILabrary.Controllers
{
    [Route("book")]
    public class BookController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;
        private readonly ILibrarySessionService _sessionService;
        private readonly IFileService _fileService;
        private readonly IBookService _bookService;

        public BookController(
            AppDbContext db,
            IMapper mapper,
            ILibrarySessionService sessionService,
            IFileService fileService,
            IBookService bookService)
        {
            _db = db;
            _mapper = mapper;
            _sessionService = sessionService;
            _fileService = fileService;
            _bookService = bookService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("")]
        public async Task<IActionResult> Index()
        {
            if (!await _sessionService.IsAuthentificateAsync())
            {
                return RedirectToAction("Login", "Library");
            }
            return View(_bookService.GetAll(_sessionService.GetCurrentLibraryId()));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("grid")]
        public async Task<IActionResult> Grid()
        {
            if (!await _sessionService.IsAuthentificateAsync())
            {
                return RedirectToAction("Login", "Library");
            }
            var books = _bookService.GetAll(_sessionService.GetCurrentLibraryId());
            return View(books);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        [Route("{id}")]
        public IActionResult Profile(int id)
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        [Route("{bookId}/pictures")]
        public async Task<IActionResult> Pictures(int bookId)
        {
            var book = await _bookService.GetAsync(bookId);
            if (book == null)
                return View();
            var pictures = from pic in book.Images
                           orderby pic.Id ascending
                           select _mapper.Map<BookPictureViewModel>(pic);
            ViewData["page"] = "pictures";
            return View(pictures); 
        }

        /// <summary> 
        /// 
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost("create")] 
        public async Task<IActionResult> Create(BookCreateViewModel viewModel)
        {
            if (!await _sessionService.IsAuthentificateAsync())
            {
                return RedirectToAction("Login", "Library");
            }
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            // verify the barcode

            if (!string.IsNullOrWhiteSpace(viewModel.Barcode))
            {
                var barcodeExist = _db.Books.Any(x => x.Barcode.ToLower() == viewModel.Barcode && x.LibraryId == _sessionService.GetCurrentLibraryId());
                if (barcodeExist)
                {
                    ModelState.AddModelError(nameof(BookCreateViewModel.Barcode), "This barcode is already assigned to another book");
                    return View(viewModel);
                }
            }

            var book = _mapper.Map<Book>(viewModel);

            // Add tags

            if (!string.IsNullOrWhiteSpace(viewModel.BookTags))
            {
                book.Tags = viewModel.BookTags.Split(";").Select(x => new BookTag
                {
                    Name = x
                }).ToList();
            }

            // Add images

            if (viewModel.Files != null && viewModel.Files.Any())
            {
                book.Images = viewModel.Files.Select(file =>
                {
                    string savePath = _fileService.SaveFile(file);
                    return new BookPicture
                    {
                        FullPath = savePath,
                        Size = file.Length
                    };
                }).ToList();
            }
            book.LibraryId = _sessionService.GetCurrentLibraryId();
            _db.Add(book);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("update/{id}")]
        public async Task<IActionResult> Update(int id)
        {
            if (!await _sessionService.IsAuthentificateAsync())
            {
                return RedirectToAction("Login", "Library");
            }
            var book = await _bookService.GetAsync(id);
            if (book == null || book.LibraryId != _sessionService.GetCurrentLibraryId())
            {
                ViewData["exist"] = false;
                return View();
            }
            ViewData["exist"] = true;
            ViewData["page"] = "update";
            var viewModel = _mapper.Map<BookUpdateViewModel>(book);
            return PartialView(viewModel);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("update/{id}")]
        public async Task<IActionResult> Update(int id, BookUpdateViewModel viewModel)
        {
            if (!await _sessionService.IsAuthentificateAsync())
            {
                return RedirectToAction("Login", "Library");
            }
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var book = await _bookService.GetAsync(id);
            if (book == null || book.LibraryId != _sessionService.GetCurrentLibraryId())
            {
                ViewData["exist"] = false;
                return View();
            }

            var model = _mapper.Map(viewModel, book);
            _db.Books.Update(model);
            if (viewModel.File != null)
            {
                var image = new BookPicture
                {
                    BookId = book.Id,
                    FullPath = _fileService.SaveFile(viewModel.File),
                    Size = viewModel.File.Length
                };
                _db.Add(image);
            }

            await _db.SaveChangesAsync();
            ViewData["exist"] = true;
            TempData["updated"] = true;
            return View(viewModel);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var book = await _bookService.GetAsync(id);
            if (book == null)
                return RedirectToAction("Index");

            _db.Books.Remove(book);
            _db.SaveChanges();
            TempData["deleted"] = true;
            return RedirectToAction("Index");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("Search")]
        public IActionResult Search()
        {
            return View();
        }
    }
}
