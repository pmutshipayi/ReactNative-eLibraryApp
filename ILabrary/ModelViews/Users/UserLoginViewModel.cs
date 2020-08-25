using System.ComponentModel.DataAnnotations;

namespace ILabrary.ModelViews.Users
{
    public class UserLoginViewModel 
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
