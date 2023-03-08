using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movie_api.Data.Services;
using Movie_api.Data.ViewModel;

namespace Movie_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private CountryService _mo;
        public CountryController(CountryService mo)
        {
            _mo = mo;
        }
        
        [HttpPost("AddCountry")]
        public IActionResult Add(CountryView Country)
        {
            _mo.AddCountry(Country);
            return Ok();
        }
        [HttpGet("GAll_Country")]
        public IActionResult Getall()
        {
           var allCountries= _mo.GetAll();
            return Ok(allCountries);
        }
        [HttpGet("GAll_Country_movies/{id}")]
        public IActionResult Getall_m(int id)
        {
            var allMovies = _mo.Get_Movies_Country(id);
            return Ok(allMovies);
        }
        [HttpGet("Gone_Country/{id}")]
        public IActionResult GetOne(int id)
        {
            var Country = _mo.gett_Country(id);
            return Ok(Country);
        }
        [HttpDelete("delete_Country/{id}")]
        public IActionResult delete(int id)
        {
            _mo.delete_Country(id);
            return Ok();
        }
        [HttpPut("update_Country/{id}")]
        public IActionResult update(int id, CountryView Country)
        {
            _mo.update_Country(id, Country);
            return Ok();
        }
    }
}
