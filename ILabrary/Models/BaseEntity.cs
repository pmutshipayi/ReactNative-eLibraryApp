using System;
using System.ComponentModel.DataAnnotations;

namespace ILabrary.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
    }
}
