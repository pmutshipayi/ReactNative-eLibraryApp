using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ILabrary.Models
{
    public class UserSession : Session
    {
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}
