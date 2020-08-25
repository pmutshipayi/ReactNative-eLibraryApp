using AutoMapper;
using ILabrary.Data;
using ILabrary.Models;
using ILabrary.Models.Libraries;
using ILabrary.ModelViews.Libraries;
using ILabrary.Services.Libraries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ILabrary.Controllers
{
    public class LibraryController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;
        private readonly ILibrarySessionService _sessionService;

        public LibraryController(AppDbContext db, IMapper mapper, ILibrarySessionService librarySessionService)
        {
            _db = db;
            _mapper = mapper;
            _sessionService = librarySessionService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        private IActionResult CreateSession(LibraryUser user)
        {
            var session = new LibraryUserSession
            {
                User = user,
                Token = Guid.NewGuid().ToString()
            };
            _db.Add(session);
            _db.SaveChanges();
            Response.Cookies.Append(SesssionKeys.LibrarySessionKey, session.Token, new CookieOptions
            {
                Path = "/"
            });
            return RedirectToAction("Index", "Book");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// Create a library
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Register(LibraryCreateViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var user = _mapper.Map<LibraryUser>(viewModel);
            var library = _mapper.Map<Library>(viewModel);
            user.Library = library;

            // Create the session

            var session = new LibraryUserSession
            {
                User = user,
                Token = Guid.NewGuid().ToString()
            };
            _db.Add(session);
            _db.SaveChanges();
            Response.Cookies.Append(SesssionKeys.LibrarySessionKey, session.Token, new CookieOptions
            {
                Path = "/"
            });
            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Login(LibraryLoginViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);
            IActionResult InvalidUsername()
            {
                ModelState.AddModelError(nameof(LibraryLoginViewModel.Username), "Invalid username.");
                return View(viewModel);
            }

            var username = viewModel.Username.Split("@");
            if (username.Count() < 2)
            {
                return InvalidUsername();
            }

            var library = _db.Libraries.FirstOrDefault(x => x.UniqueId == username[1]);
            if (library == null)
            {
                return InvalidUsername();
            }

            // Get the user

            var user = _db.LibraryUsers.FirstOrDefault(x => x.Username == username[0] && x.LibraryId == library.Id && x.Password == viewModel.Password);
            if (user == null)
            {
                return InvalidUsername();
            }

            // Create session

            return CreateSession(user);
        }

        public async Task<IActionResult> Logout()
        {
            if (!await _sessionService.IsAuthentificateAsync())
            {
                return RedirectToAction("Login");
            }
            Response.Cookies.Append(SesssionKeys.LibrarySessionKey, "", new CookieOptions
            {
                Path = "/",
                Expires = DateTime.Now.AddDays(-1)
            });
            return RedirectToAction("Login", "Library");
        }

        public async Task<IActionResult> Update()
        {
            if (! await _sessionService.IsAuthentificateAsync())
            {
                return RedirectToAction("Login");
            }
            return View(_db.Libraries.FirstOrDefault(x => x.Id == _sessionService.GetCurrentLibraryId()));
        }

        [HttpPost]
        public async Task<IActionResult> Update(Library library)
        {
            if (!await _sessionService.IsAuthentificateAsync())
            {
                return RedirectToAction("Login");
            }
            _db.Update(library);
            _db.SaveChanges();
            return RedirectToAction("Index", "Book");
        }
    }
}
