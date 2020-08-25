using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ILabrary.Models.Libraries
{
    public class BookReservation : BaseEntity
    {
        /// <summary>
        /// Gets or sets the user id
        /// </summary>
        [Required]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the booking token
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Gets or ses the user
        /// </summary>
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}
