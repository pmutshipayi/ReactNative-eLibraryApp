using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ILabrary.Models.Libraries
{
    public class Book : BaseEntity
    {
        /// <summary>
        /// Gets or sets the book name
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Barcode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Qty { get; set; }

        /// <summary>
        /// Gets or sets the library id
        /// </summary>
        public int LibraryId { get; set; }

        /// <summary>
        /// Gets or sets the book topic
        /// </summary>
        public int? TopicId { get; set; }

        public bool IsAvailable { get; set; }

        /// <summary>
        /// Gets or sets the library
        /// </summary>
        [ForeignKey(nameof(LibraryId))]
        public Library Library { get; set; }

        /// <summary>
        /// Gets or sets the book topics
        /// </summary>
        [ForeignKey(nameof(TopicId))]
        public BookTopic Topic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool AllowOnlineReservation { get; set; } = true;

        /// <summary>
        /// Gets or sets book images
        /// </summary>
        public ICollection<BookPicture> Images { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ICollection<BookTag> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ICollection<BookAllocationSpec> Allocations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [NotMapped]
        public int QtyBorred { get; set; }

        [NotMapped]
        public int QtyAvailable { get; set; }
    }
}
