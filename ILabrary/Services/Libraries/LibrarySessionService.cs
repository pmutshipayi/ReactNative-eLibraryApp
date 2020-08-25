using ILabrary.Data;
using ILabrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ILabrary.Services.Libraries
{
    public class LibrarySessionService : ILibrarySessionService
    {
        private readonly AppDbContext _db;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LibrarySessionService(AppDbContext db, IHttpContextAccessor httpContextAccessor)
        {
            _db = db;
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// 
        /// </summary>
        private string Cookie => _httpContextAccessor.HttpContext.Request.Cookies[SesssionKeys.LibrarySessionKey];

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetCurrentLibraryId()
        {
            if (string.IsNullOrWhiteSpace(Cookie))
                throw new UnauthorizedAccessException();
            var session = _db.LibraryUserSessions
                .Include(x => x.User)
                   .ThenInclude(x => x.Library)
                .FirstOrDefault(x => x.Token == Cookie);
            if (session == null)
                return 0;
            return session.User.LibraryId;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetCurrentLibraryUniqueId()
        {
            if (string.IsNullOrWhiteSpace(Cookie))
                throw new UnauthorizedAccessException();
            var session = _db.LibraryUserSessions
                .Include(x => x.User)
                   .ThenInclude(x => x.Library)
                .FirstOrDefault(x => x.Token == Cookie);
            return session.User.Library.UniqueId;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<bool> IsAuthentificateAsync()
        {
            var cookie = _httpContextAccessor.HttpContext.Request.Cookies[SesssionKeys.LibrarySessionKey];
            if (string.IsNullOrWhiteSpace(cookie))
                return false;
            var session = await _db.LibraryUserSessions.AnyAsync(x => x.Token == cookie);
            return session;
        }
    }
}
