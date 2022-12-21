using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace MusicApp.Models
{
    public class Song
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Song Name")]
        public string SongName { get; set; }
        [Required]
        public string Artist { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Genre { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [Display(Name = "Video")]
        [DataType(DataType.Url)]
        public string URL { get; set; }
    }
}
