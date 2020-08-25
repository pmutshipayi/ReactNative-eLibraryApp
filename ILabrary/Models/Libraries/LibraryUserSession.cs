using System.ComponentModel.DataAnnotations.Schema;

namespace ILabrary.Models.Libraries
{
    public class LibraryUserSession : Session
    {
        /// <summary>
        /// Gets or sets user own of the session
        /// </summary>
        [ForeignKey(nameof(UserId))]
        public LibraryUser User { get; set; }
    }
}
