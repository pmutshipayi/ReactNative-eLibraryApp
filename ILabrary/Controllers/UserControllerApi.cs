using AutoMapper;
using ILabrary.Data;
using ILabrary.Models;
using ILabrary.ModelViews.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace ILabrary.Controllers
{
    [ApiController]
    [Route("api/users/")]
    public class UserControllerApi : Controller
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;
        public const string TokenName = "authorization";

        public UserControllerApi(AppDbContext db,
            IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateAsync(UserCreateViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var emailExist = await _db.Users.AnyAsync(x => x.Email == viewModel.Email);
            if (emailExist)
            {
                ModelState.AddModelError("email", "This email address is already used.");
                return BadRequest(ModelState);
            }

            var user = _mapper.Map<User>(viewModel);
            var session = new UserSession
            {
                User = user,
                Token = Guid.NewGuid().ToString()
            };
            _db.Add(session);
            await _db.SaveChangesAsync();

            // Set the authentification token

            Response.Headers.Add(TokenName, session.Token);
            return Ok(_mapper.Map<UserViewModel>(user));
        }

        /// <summary>
        /// Get the profile of the authentificated user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetProfileAsync()
        {
            var token = Request.Headers[TokenName];
            var session = await _db.UserSessions
                .Include(x => x.User)
                .FirstOrDefaultAsync(x => x.Token == token);
            if (session == null)
                return null;
            return Ok(_mapper.Map<UserViewModel>(session.User));
        }

        /// <summary>
        /// PUT  localhost:13456/api/users
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdateAsync(UserViewModel viewModel)
        {
            var token = Request.Headers[TokenName];
            var session = await _db.UserSessions
               .Include(x => x.User)
               .FirstOrDefaultAsync(x => x.Token == token);

            if (!ModelState.IsValid)
                return BadRequest(viewModel);

            if (session == null)
            {
                ModelState.AddModelError("error", "It seems your are not yet logged in. : " + token);
                return BadRequest(ModelState);
            }

            // map

            var mapUser = _mapper.Map(viewModel, session.User);
            _db.Update(mapUser);
            await _db.SaveChangesAsync();
            return Ok(_mapper.Map<UserViewModel>(mapUser));
        }

        /// <summary>
        /// Logout 
        /// </summary>
        /// <returns></returns>
        [HttpGet("logout")]
        public async Task<IActionResult> LogoutAsync()
        {
            var token = Request.Headers[TokenName];
            var session = await _db.UserSessions
               .Include(x => x.User)
               .FirstOrDefaultAsync(x => x.Token == token);
            if (session == null)
                return Ok();

            // delete cookie

            _db.Remove(session);
            await _db.SaveChangesAsync();
            return Ok();
        }

        /// <summary>
        /// Delete the user account
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync()
        {
            var token = Request.Headers[TokenName];
            var session = await _db.UserSessions
               .Include(x => x.User)
               .FirstOrDefaultAsync(x => x.Token == token);
            if (session == null)
                return Ok();

            _db.Remove(session.User);
            await _db.SaveChangesAsync();
            return Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost("set_password")]
        public async Task<IActionResult> UpdatePasswordAsync(UserUpdatePasswordViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(viewModel);

            var token = Request.Headers[TokenName];
            var session = await _db.UserSessions
               .Include(x => x.User)
               .FirstOrDefaultAsync(x => x.Token == token);
            if (session == null)
                return BadRequest();

            if (session.User.Password != viewModel.CurrentPassword)
            {
                ModelState.AddModelError("error", "Your current password is invalid");
                return BadRequest(ModelState);
            }

            // Set password

            session.User.Password = viewModel.NewPassword;
            _db.Update(session.User);
            await _db.SaveChangesAsync();
            return Ok();
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("auth")]
        public async Task<IActionResult> LoginAsync(UserLoginViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(viewModel);
            var user = await _db.Users
                .FirstOrDefaultAsync(x => x.Email == viewModel.Email);
            if (user == null)
            {
                ModelState.AddModelError("email", "This email address does not exist");
                return BadRequest(ModelState);
            }
            if (user.Password != viewModel.Password)
            {
                ModelState.AddModelError("password", "This password is not correct");
                return BadRequest(ModelState);
            }

            var session = new UserSession
            {
                User = user,
                Token = Guid.NewGuid().ToString()
            };
            _db.Add(session);
            await _db.SaveChangesAsync();

            // Set the authentification token

            Response.Headers.Add(TokenName, session.Token);
            return Ok(_mapper.Map<UserViewModel>(user));
        }
    }
}
