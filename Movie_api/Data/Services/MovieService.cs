using Microsoft.EntityFrameworkCore;
using Movie_api.Data.Model;
using Movie_api.Data.ViewModel;


namespace Movie_api.Data.Services
{
    public class MovieService
    {
        private AppDbContext _db;
        public MovieService(AppDbContext db)
        {
            _db = db;
        }
        public void AddMovie(MovieView m) {
            Movie movie = new Movie(); 
            if (m != null) { 
            movie.Created = DateTime.Now;
                movie.Name = m.Name;
                movie.Description = m.Description;
                movie.GenreId = m.GenreId;
                movie.ImgUrl = m.ImgUrl;
                movie.RelaseDate = m.RelaseDate;
                movie.Rate = m.Rate;
                movie.DirectorId = m.DirectorId;
                movie.CountryId = m.CountryId;

            }
        _db.Add(movie);
        _db.SaveChanges();
        }
        public IEnumerable<Movie> GetAll() { 
        var movies = _db.Movies.Include(d=>d.Director).Include(d => d.Country).Include(d => d.Genre).ToList();
            return movies;
        }
        public Movie gett_movie(int id) {
            var movie = _db.Movies.Include(d => d.Director).Include(d => d.Country).Include(d => d.Genre).FirstOrDefault(m=>m.Id==id);
            return movie;
        }
        public void delete_movie(int id)
        {
            var movie = _db.Movies.FirstOrDefault(x=>x.Id==id);
            _db.Movies.Remove(movie);
            _db.SaveChanges();
           
        }
        public void update_movie(int id,MovieView m)
        {
            var movie = _db.Movies.FirstOrDefault(x => x.Id == id);
            if ( m != null)
            {
                movie.Name = m.Name;
                movie.Description = m.Description;
                movie.GenreId = m.GenreId;
                movie.ImgUrl = m.ImgUrl;
                movie.RelaseDate = m.RelaseDate;
                movie.Rate = m.Rate;
                movie.DirectorId = m.DirectorId;
                movie.CountryId = m.CountryId;
            }
            _db.Movies.Update(movie);
            _db.SaveChanges();
        }
    }
}
