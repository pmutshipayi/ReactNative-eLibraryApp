using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ILabrary.Models.Libraries
{
    public class Library : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string UniqueId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        [EmailAddress]
        public string EmailAddress2 { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public ICollection<LibraryUser> Users { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
