using System.ComponentModel.DataAnnotations.Schema;

namespace ILabrary.Models.Libraries
{
    public abstract class BookAllocationSpecBase : BaseEntity
    {
        /// <summary>
        /// Gets or sets the book id
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// Gets or sets the qty
        /// </summary>
        public int Qty { get; set; }

        /// <summary>
        /// Gets or sets the book
        /// </summary>
        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; }
    }
}
