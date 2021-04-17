using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroundWord.Models
{
    public class Room
    {
        [Key]
        public string RoomId { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Sensor> Sensors { get; set; } = new LinkedList<Sensor>();
    }
}
