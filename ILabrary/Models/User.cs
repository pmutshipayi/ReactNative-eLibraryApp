﻿using System.ComponentModel.DataAnnotations;

namespace ILabrary.Models
{
    public class User : BaseEntity
    {
        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IDNumber { get; set; }

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
        public string Password { get; set; }
    }
}
