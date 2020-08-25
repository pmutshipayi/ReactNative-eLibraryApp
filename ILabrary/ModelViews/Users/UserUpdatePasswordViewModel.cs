using System.ComponentModel.DataAnnotations;

namespace ILabrary.ModelViews.Users
{
    public class UserUpdatePasswordViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "You must put your current password")]
        public string CurrentPassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [MinLength(6)]
        [Required(ErrorMessage = "The new password cannot be empty")]
        public string NewPassword { get; set; }
    }
}
