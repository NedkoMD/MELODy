using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace MusicApp.Models
{
    public class Users
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string Username { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
