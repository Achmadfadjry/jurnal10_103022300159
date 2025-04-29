namespace modul10_103022300159
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public List<string> stars { get; set; }
        public string Description { get; set; }

        public Movie (string title, string director,List <string> stars, string description)
        {
            this.Title = title;
            this.Director = director;
            this.stars = stars;
            this.Description = description;
            
        }
    }
}
