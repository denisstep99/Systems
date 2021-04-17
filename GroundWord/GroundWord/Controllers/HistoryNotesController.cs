using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GroundWord.Models;
using AppContext = GroundWord.Models.AppContext;

namespace GroundWord.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryNotesController : ControllerBase
    {
        private readonly AppContext _context;

        public HistoryNotesController(AppContext context)
        {
            _context = context;
        }

        // DELETE: api/HistoryNote
        [HttpDelete]
        public async Task<IActionResult> DeleteNistoryNote()
        {
            int n = _context.Database.ExecuteSqlRaw("TRUNCATE TABLE [HistoryNotes]");
            await _context.SaveChangesAsync();

            return Ok(n);
        }

        [HttpGet("{sensorId}")]
        public async Task<ActionResult<IEnumerable<HistoryNote>>> GetHistoryNotes(string sensorId)
        {
            var sensor = await _context.Sensors
                .Include(s => s.History)
                .Where(s => s.SensorId == sensorId)
                .FirstOrDefaultAsync();

            if (sensor == null)
            {
                return NotFound();
            }
            return sensor.History.ToList();
        }

        // POST: api/HistoryNotes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("{sensorId}")]
        public async Task<ActionResult<HistoryNote>> PostHistoryNote(string sensorId, HistoryNote historyNote)
        {
            _context.HistoryNotes.Add(historyNote);
            var sensor = await _context.Sensors.FindAsync(sensorId);
            if (sensor == null)
            {
                return NotFound();
            }
            sensor.History.Add(historyNote);
            _context.Entry(sensor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HistoryNoteExists(historyNote.HistoryNoteId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Ok(historyNote);
        }

        private bool HistoryNoteExists(string id)
        {
            return _context.HistoryNotes.Any(e => e.HistoryNoteId == id);
        }
    }
}
