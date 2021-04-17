using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroundWord.Models
{
    public class User
    {
        [Key]
        public string UserId { get; set; } = Guid.NewGuid().ToString();
        [Required, MinLength(6)]
        public string Password { get; set; }
        [Required]
        public string UserName { get; set; }
        public virtual ICollection<Room> Rooms { get; set; } = new LinkedList<Room>();
    }
}
