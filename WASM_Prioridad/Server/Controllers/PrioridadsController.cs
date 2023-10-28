using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WASM_Prioridad.Server.DAL;
using WASM_Prioridad.Shared;

namespace WASM_Prioridad.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrioridadsController : ControllerBase
    {
        private readonly PrioridadContext _context;

        public PrioridadsController(PrioridadContext context)
        {
            _context = context;
        }

        // GET: api/Prioridads
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prioridad>>> GetPrioridades()
        {
          if (_context.Prioridades == null)
          {
              return NotFound();
          }
            return await _context.Prioridades.ToListAsync();
        }

        // GET: api/Prioridads/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Prioridad>> GetPrioridad(int id)
        {
          if (_context.Prioridades == null)
          {
              return NotFound();
          }
            var prioridad = await _context.Prioridades.FindAsync(id);

            if (prioridad == null)
            {
                return NotFound();
            }

            return prioridad;
        }

        // PUT: api/Prioridads/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrioridad(int id, Prioridad prioridad)
        {
            if (id != prioridad.PrioridadId)
            {
                return BadRequest();
            }

            _context.Entry(prioridad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrioridadExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Prioridads
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Prioridad>> PostPrioridad(Prioridad prioridad)
        {
          if (_context.Prioridades == null)
          {
              return Problem("Entity set 'PrioridadContext.Prioridades'  is null.");
          }
            _context.Prioridades.Add(prioridad);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrioridad", new { id = prioridad.PrioridadId }, prioridad);
        }

        // DELETE: api/Prioridads/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrioridad(int id)
        {
            if (_context.Prioridades == null)
            {
                return NotFound();
            }
            var prioridad = await _context.Prioridades.FindAsync(id);
            if (prioridad == null)
            {
                return NotFound();
            }

            _context.Prioridades.Remove(prioridad);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PrioridadExists(int id)
        {
            return (_context.Prioridades?.Any(e => e.PrioridadId == id)).GetValueOrDefault();
        }
    }
}
