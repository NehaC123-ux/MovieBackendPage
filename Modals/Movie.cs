using System.ComponentModel.DataAnnotations;

namespace MovieApplication.Modals
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Plot { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
