namespace Movie_api.Data.Model
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ? Rate { get; set; }
         public DateTime? Created { get; set; } = default(DateTime?);
        public String ImgUrl { get; set; } 
        public  DateTime RelaseDate{ get; set; }
        public string Description { get; set; }

        public int GenreId { get; set; }
        public Genre  Genre { get; set; }

        public int CountryId { get; set; }
        public Country  Country { get; set; }

        public int DirectorId { get; set; }
        public Director  Director { get; set; }
    }
}
