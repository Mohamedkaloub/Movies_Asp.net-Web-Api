using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movie_api.Data.Services;
using Movie_api.Data.ViewModel;

namespace Movie_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private MovieService _mo;
        public MovieController(MovieService mo)
        {
            _mo = mo;
        }
        
        [HttpPost("AddMovie")]
        public IActionResult Add(MovieView movie)
        {
            _mo.AddMovie(movie);
            return Ok();
        }
        [HttpGet("GAll")]
        public IActionResult Getall()
        {
           var allmovies= _mo.GetAll();
            return Ok(allmovies);
        }
        [HttpGet("Gone/{id}")]
        public IActionResult GetOne(int id)
        {
            var movie = _mo.gett_movie(id);
            return Ok(movie);
        }
        [HttpDelete("delete_movie/{id}")]
        public IActionResult delete(int id)
        {
            _mo.delete_movie(id);
            return Ok();
        }
        [HttpPut("update_movie/{id}")]
        public IActionResult update(int id, MovieView movie)
        {
            _mo.update_movie(id, movie);
            return Ok();
        }
    }
}
