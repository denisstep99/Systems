using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroundWord.Models
{
    public class Sensor
    {
        [Key]
        public string SensorId { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public string Name { get; set; }
        public virtual ICollection<HistoryNote> History { get; set; } = new LinkedList<HistoryNote>();
    }
}
