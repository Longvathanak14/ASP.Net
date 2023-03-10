using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie_App.Models
{

    public enum Genre
    {
        Drama =1,
        Fantastic=2,
        Action=3,
        Horor=4,
        Romantic=5,
        Advanture=6,
        Science=7

    }

    public class Movie
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public Genre? Genre { get; set; }
        public string? Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}
