using System.ComponentModel.DataAnnotations;

namespace ILabrary.ModelViews.Libraries
{
    public class LibraryCreateViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [MinLength(4)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [MinLength(5)]
        [Display(Name = "Business ID")]
        [Required(ErrorMessage = "The library unique name is required")]
        public string UniqueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the user first name
        /// </summary>
        [Required]
        [MinLength(3)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        [MinLength(3)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email address")]
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        [MinLength(3)]
        public string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
