using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ILabrary.ModelViews.Libraries
{
    public class BookUpdateViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Barcode { get; set; }

        /// <summary>
        /// 
        /// </summary>
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

        public bool IsAvailable { get; set; }

        /// <summary>
        /// Gets or sets the qty borrowed
        /// </summary>
        public int Borrowed { get; set; }

        /// <summary>
        /// Gets or sets the book tags
        /// </summary>
        public ICollection<BookTagViewModel> Tags { get; set; }

        public IFormFile File { get; set; }
    }
}
