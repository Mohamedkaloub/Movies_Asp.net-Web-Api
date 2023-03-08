using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movie_api.Data.Services;
using Movie_api.Data.ViewModel;

namespace Movie_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private DirectorService _mo;
        public DirectorController(DirectorService mo)
        {
            _mo = mo;
        }
        
        [HttpPost("AddDirector")]
        public IActionResult Add(DirectorView Director)
        {
            _mo.AddDirector(Director);
            return Ok();
        }
        [HttpGet("GAll_Director")]
        public IActionResult Getall()
        {
           var allDirectors= _mo.GetAll();
            return Ok(allDirectors);
        }
        [HttpGet("GAll_Director_movies/{id}")]
        public IActionResult Getall_m(int id)
        {
            var allMovies = _mo.Get_Movies_Director(id);
            return Ok(allMovies);
        }
        [HttpGet("Gone_Director/{id}")]
        public IActionResult GetOne(int id)
        {
            var Director = _mo.gett_Director(id);
            return Ok(Director);
        }
        [HttpDelete("delete_Director/{id}")]
        public IActionResult delete(int id)
        {
            _mo.delete_Director(id);
            return Ok();
        }
        [HttpPut("update_Director/{id}")]
        public IActionResult update(int id, DirectorView Director)
        {
            _mo.update_Director(id, Director);
            return Ok();
        }
    }
}
