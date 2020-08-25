using System.ComponentModel.DataAnnotations.Schema;

namespace ILabrary.Models.Libraries
{
    public class BookPicture : BaseEntity
    {
        public string FullPath { get; set; }
        public string Caption { get; set; }
        public long Size { get; set; }
        public int BookId { get; set; }
        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; }
    }
}
