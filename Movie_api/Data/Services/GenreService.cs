using Movie_api.Data.Model;
using Movie_api.Data.ViewModel;

namespace Movie_api.Data.Services
{
    public class GenreService
    {
        private AppDbContext _db;
        public GenreService(AppDbContext db)
        {
            _db = db;
        }
        public void AddGenre(GenreView G) {
            Genre Genre = new Genre(); 
            if (G != null) { 
           Genre.Name = G.Name;
            }
        _db.Genres.Add(Genre);
        _db.SaveChanges();
        }
        public IEnumerable<Genre> GetAll() { 
        var Genres = _db.Genres.ToList();
            return Genres;
        }
        public IEnumerable<Movie> Get_Movies_Genre(int id)
        {
            var Movies = _db.Movies.Where(m => m.GenreId == id).ToList();
           
                return Movies;
           
        }
        public Genre gett_Genre(int id) {
            var Genre = _db.Genres.FirstOrDefault(m=>m.Id==id);
            return Genre;
        }
        public void delete_Genre(int id)
        {
            var Genre = _db.Genres.FirstOrDefault(x=>x.Id==id);
            _db.Genres.Remove(Genre);
            _db.SaveChanges();
           
        }
        public void update_Genre(int id,GenreView G)
        {
            Genre Genre = new Genre();
            if (G != null)
            {
                Genre.Name = G.Name;
            }
            _db.Genres.Update(Genre);
            _db.SaveChanges();
        }
    }
}
