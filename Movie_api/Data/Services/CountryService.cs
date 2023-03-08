using Movie_api.Data.Model;
using Movie_api.Data.ViewModel;

namespace Movie_api.Data.Services
{
    public class CountryService
    {
        private AppDbContext _db;
        public CountryService(AppDbContext db)
        {
            _db = db;
        }
        public void AddCountry(CountryView G) {
            Country Country = new Country(); 
            if (G != null) { 
           Country.Name = G.Name;
           Country.Language=G.Language;
            }
        _db.Countries.Add(Country);
        _db.SaveChanges();
        }
        public IEnumerable<Country> GetAll() { 
        var Countrys = _db.Countries.ToList();
            return Countrys;
        }
        public IEnumerable<Movie> Get_Movies_Country(int id)
        {
            var Movies = _db.Movies.Where(m => m.CountryId == id).ToList();
            return Movies;

        }
        public Country gett_Country(int id) {
            var Country = _db.Countries.FirstOrDefault(m=>m.Id==id);
            return Country;
        }
        public void delete_Country(int id)
        {
            var Country = _db.Countries.FirstOrDefault(x=>x.Id==id);
            _db.Countries.Remove(Country);
            _db.SaveChanges();
           
        }
        public void update_Country(int id,CountryView G)
        {
            Country Country = new Country();
            if (G != null)
            {
                Country.Name = G.Name;
                Country.Language = G.Language;
            }
            _db.Countries.Update(Country);
            _db.SaveChanges();
        }
    }
}
