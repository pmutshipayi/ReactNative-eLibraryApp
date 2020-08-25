using System.ComponentModel.DataAnnotations;

namespace ILabrary.Models.Libraries
{
    public class BookTopic : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
