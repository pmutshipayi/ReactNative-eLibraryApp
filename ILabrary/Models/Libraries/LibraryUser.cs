using System.ComponentModel.DataAnnotations.Schema;

namespace ILabrary.Models.Libraries
{
    public class LibraryUser : Person
    {
        /// <summary>
        /// Gets or set the library id
        /// </summary>
        public int LibraryId { get; set; }

        /// <summary>
        /// Gets or sets the library
        /// </summary>
        [ForeignKey(nameof(LibraryId))]
        public Library Library { get; set; }
    }
}
