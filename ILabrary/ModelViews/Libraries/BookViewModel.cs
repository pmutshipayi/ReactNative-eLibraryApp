using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ILabrary.ModelViews.Libraries
{
    public class BookViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Barcode { get; set; }

        [Display(Name = "Allow online reservation")]
        public bool AllowOnlineReservation { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Total Qty")]
        public int Qty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Qty on hand")]
        public int QtyAvailable { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IsAvailable { get; set; }

        /// <summary>
        /// Gets or sets the qty borrowed
        /// </summary>
        public int Borrowed { get; set; }

        /// <summary>
        /// Gets or sets the book topic name
        /// </summary>
        public string TopicName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public LibraryViewModel Library { get; set; }

        /// <summary>
        /// Gets or sets the book tags
        /// </summary>
        public ICollection<BookTagViewModel> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ICollection<BookPictureViewModel> Images { get; set; }
    }
}
