using System.ComponentModel.DataAnnotations;

namespace ILabrary.ModelViews.Libraries
{
    public class LibraryLoginViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
