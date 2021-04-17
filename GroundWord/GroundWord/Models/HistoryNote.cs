using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroundWord.Models
{
    public class HistoryNote
    {
        public string HistoryNoteId { get; set; } = Guid.NewGuid().ToString();
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double Illumination { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public double GroundHumidity { get; set; }
    }
}
