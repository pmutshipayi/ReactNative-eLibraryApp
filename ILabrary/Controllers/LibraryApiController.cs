using System.Threading.Tasks;
using ILabrary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ILabrary.Controllers
{
    [ApiController]
    [Route("api/library/")]
    public class LibraryApiController : Controller
    {
        private readonly AppDbContext _db;

        public LibraryApiController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _db.Libraries.ToListAsync();
            return Ok(data);
        }
    }
}