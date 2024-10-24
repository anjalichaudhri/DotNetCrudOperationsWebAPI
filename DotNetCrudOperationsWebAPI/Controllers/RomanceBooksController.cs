using DotNetCrudOperationsWebAPI.Data;
using DotNetCrudOperationsWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetCrudOperationsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RomanceBooksController : ControllerBase
    {
        private readonly FavoriteBooksContext _favoriteBooksContext;

        public RomanceBooksController(FavoriteBooksContext favoriteBooksContext)
        {
            _favoriteBooksContext = favoriteBooksContext;
        }

        // get operation

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RomanceBook>>> GetAllRomanceBooks()
        {
            // table exists or not
            if(_favoriteBooksContext.RomanceBooks == null)
            {
                return NotFound();
            }

            return await _favoriteBooksContext.RomanceBooks.ToListAsync();
        }
    }
}
