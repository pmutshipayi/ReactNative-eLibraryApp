using System.ComponentModel.DataAnnotations;

namespace ILabrary.ModelViews.Libraries
{
    public class LibraryUserUpdateViewModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the user name
        /// </summary>
        [Required]
        [MinLength(4)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the email address
        /// </summary>
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the password
        /// </summary>
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
