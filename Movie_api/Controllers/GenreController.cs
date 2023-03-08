using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movie_api.Data.Services;
using Movie_api.Data.ViewModel;

namespace Movie_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private GenreService _mo;
        public GenreController(GenreService mo)
        {
            _mo = mo;
        }
        
        [HttpPost("AddGenre")]
        public IActionResult Add(GenreView Genre)
        {
            _mo.AddGenre(Genre);
            return Ok();
        }
        [HttpGet("GAll_Genre")]
        public IActionResult Getall()
        {
           var allGenres= _mo.GetAll();
            return Ok(allGenres);
        }
        [HttpGet("GAll_Genre_movies/{id}")]
        public IActionResult Getall_m(int id)
        {
            var allMovies = _mo.Get_Movies_Genre(id);
            return Ok(allMovies);
        }
        [HttpGet("Gone_Genre/{id}")]
        public IActionResult GetOne(int id)
        {
            var Genre = _mo.gett_Genre(id);
            return Ok(Genre);
        }
        [HttpDelete("delete_Genre/{id}")]
        public IActionResult delete(int id)
        {
            _mo.delete_Genre(id);
            return Ok();
        }
        [HttpPut("update_Genre/{id}")]
        public IActionResult update(int id, GenreView Genre)
        {
            _mo.update_Genre(id, Genre);
            return Ok();
        }
    }
}
