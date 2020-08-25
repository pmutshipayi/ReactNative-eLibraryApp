using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ILabrary.ModelViews.Libraries
{
    public class BookCreateViewModel
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

        public bool IsAvailable { get; set; }

        /// <summary>
        /// Gets or sets the barcode
        /// </summary>
        public string Barcode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Quantity")]
        [Range(0, int.MaxValue)]
        public int Qty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? TopicId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Tags (separated by semi colon (;))")]
        public string BookTags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ICollection<IFormFile> Files { get; set; }
    }
}
