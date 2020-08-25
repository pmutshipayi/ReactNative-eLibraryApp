using AutoMapper;
using ILabrary.Data;
using ILabrary.Models.Libraries;
using ILabrary.ModelViews.Libraries;
using ILabrary.Services.Libraries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ILabrary.Controllers
{
    public class LibraryUserController : Controller
    {
        private readonly AppDbContext _db;
        private readonly ILibrarySessionService _sessionService;
        private readonly IMapper _mapper;

        public LibraryUserController(
            AppDbContext db,
            ILibrarySessionService sessionService,
            IMapper mapper)
        {
            _db = db;
            _sessionService = sessionService;
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private LibraryUser GetUserById(int id)
        {
            return _db.LibraryUsers.FirstOrDefault(x => x.LibraryId == _sessionService.GetCurrentLibraryId() && x.Id == id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            if (!await _sessionService.IsAuthentificateAsync())
            {
                return RedirectToAction("Login", "Library");
            }
            var users = _db.LibraryUsers
                .Include(x => x.Library)
                .Where(x => x.LibraryId == _sessionService.GetCurrentLibraryId())
                .Select(x => _mapper.Map<LibraryUserViewModel>(x))
                .ToList();
            return View(users);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Create()
        {
            if (!await _sessionService.IsAuthentificateAsync())
            {
                return RedirectToAction("Login", "Library");
            }
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(LibraryUserCreateViewModel viewModel)
        {
            if (!await _sessionService.IsAuthentificateAsync())
            {
                return RedirectToAction("Login", "Library");
            }
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            int libraryId = _sessionService.GetCurrentLibraryId();
            bool usernameUsed = _db.LibraryUsers
                .Any(x => x.Username == viewModel.Username && x.LibraryId == libraryId);
            if (usernameUsed)
            {
                ModelState.AddModelError(nameof(LibraryCreateViewModel.Username), "This username is taken.");
                return View(viewModel);
            }

            var user = _mapper.Map<LibraryUser>(viewModel);
            user.LibraryId = libraryId;

            // Create the user

            _db.LibraryUsers.Add(user);
            _db.SaveChanges();
            TempData["account_created"] = true;
            return RedirectToAction("Create");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Update(int id)
        {
            if (!await _sessionService.IsAuthentificateAsync())
            {
                return RedirectToAction("Login", "Library");
            }
            var user = GetUserById(id);
            if (user == null)
            {
                return View(new LibraryUserUpdateViewModel());
            }
            var viewModel = _mapper.Map<LibraryUserUpdateViewModel>(user);
            return View(viewModel);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Update(int id, LibraryUserUpdateViewModel viewModel)
        {
            if (!await _sessionService.IsAuthentificateAsync())
            {
                return RedirectToAction("Login", "Library");
            }
            IActionResult UpdateFailed()
            {
                TempData["updated"] = false;
                return View(viewModel);
            }

            if (!ModelState.IsValid)
                return View(viewModel);
            if (id != viewModel.Id)
            {
                return UpdateFailed();
            }
            var user = GetUserById(id);
            if (user == null)
            {
                return UpdateFailed();
            }

            var model = _mapper.Map(viewModel, user);
            _db.LibraryUsers.Update(model);
            _db.SaveChanges();
            TempData["updated"] = true;
            return View(viewModel);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Delete(int id)
        {
            if (!await _sessionService.IsAuthentificateAsync())
            {
                return RedirectToAction("Login", "Library");
            }
            var user = GetUserById(id);
            if (user == null)
            {
                return RedirectToAction("Index");
            }
            _db.LibraryUsers.Remove(user);
            _db.SaveChanges();
            TempData["deleted"] = true;
            return RedirectToAction("Index");
        }
    }
}
