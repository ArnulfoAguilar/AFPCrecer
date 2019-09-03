using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AFPCrecer.Models;

namespace AFPCrecer.Controllers
{
    [Route("api/Afiliaciones")]
    [ApiController]
    public class AfiliacionesController : ControllerBase
    {
        private readonly AFPCrecerContext _context;

        public AfiliacionesController(AFPCrecerContext context)
        {
            _context = context;
        }

        // GET: api/Afiliaciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Afiliacion>>> GetAfiliacion()
        {
            return await _context.Afiliacion.ToListAsync();
        }

        // GET: api/Afiliaciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Afiliacion>> GetAfiliacion(int id)
        {
            var afiliacion = await _context.Afiliacion.FindAsync(id);

            if (afiliacion == null)
            {
                return NotFound();
            }

            return afiliacion;
        }

        // PUT: api/Afiliaciones/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAfiliacion(int id, Afiliacion afiliacion)
        {
            if (id != afiliacion.Id)
            {
                return BadRequest();
            }

            _context.Entry(afiliacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AfiliacionExists(id))
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

        // POST: api/Afiliaciones
        [HttpPost]
        public async Task<ActionResult<Afiliacion>> PostAfiliacion(Afiliacion afiliacion)
        {
            _context.Afiliacion.Add(afiliacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAfiliacion", new { id = afiliacion.Id }, afiliacion);
        }

        // DELETE: api/Afiliaciones/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Afiliacion>> DeleteAfiliacion(int id)
        {
            var afiliacion = await _context.Afiliacion.FindAsync(id);
            if (afiliacion == null)
            {
                return NotFound();
            }

            _context.Afiliacion.Remove(afiliacion);
            await _context.SaveChangesAsync();

            return afiliacion;
        }

        private bool AfiliacionExists(int id)
        {
            return _context.Afiliacion.Any(e => e.Id == id);
        }
    }
}
