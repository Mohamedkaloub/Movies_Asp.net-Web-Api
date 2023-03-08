using Movie_api.Data.Model;
using Movie_api.Data.ViewModel;

namespace Movie_api.Data.Services
{
    public class DirectorService
    {
        private AppDbContext _db;
        public DirectorService(AppDbContext db)
        {
            _db = db;
        }
        public void AddDirector(DirectorView D) {
            Director Director = new Director(); 
            if (D != null) {
                Director.Name = D.Name;
                Director.Birthday = D.Birthday;
            }
        _db.Directors.Add(Director);
        _db.SaveChanges();
        }
        public IEnumerable<Director> GetAll() { 
        var Directors = _db.Directors.ToList();
            return Directors;
        }
        public IEnumerable<Movie> Get_Movies_Director(int id)
        {
            var Movies = _db.Movies.Where(m => m.DirectorId == id).ToList();

            return Movies;

        }
        public Director gett_Director(int id) {
            var Director = _db.Directors.FirstOrDefault(m=>m.Id==id);
            return Director;
        }
        public void delete_Director(int id)
        {
            var Director = _db.Directors.FirstOrDefault(x=>x.Id==id);
            _db.Directors.Remove(Director);
            _db.SaveChanges();
           
        }
        public void update_Director(int id,DirectorView G)
        {
            Director Director = new Director();
            if (G != null)
            {
                Director.Name = G.Name;
                Director.Birthday=G.Birthday;
            }
            _db.Directors.Update(Director);
            _db.SaveChanges();
        }
    }
}
