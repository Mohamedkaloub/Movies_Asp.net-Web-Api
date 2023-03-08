namespace Movie_api.Data.ViewModel
{
    public class MovieView
    {
        public string Name { get; set; }

        public int? Rate { get; set; }
        public String ImgUrl { get; set; }
        public DateTime RelaseDate { get; set; }
        public string Description { get; set; }

        public int GenreId { get; set; }

        public int CountryId { get; set; }

        public int DirectorId { get; set; }
    }
}
