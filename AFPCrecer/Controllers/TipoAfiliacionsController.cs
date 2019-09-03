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
    [Route("api/TipoAfiliaciones")]
    [ApiController]
    public class TipoAfiliacionsController : ControllerBase
    {
        private readonly AFPCrecerContext _context;

        public TipoAfiliacionsController(AFPCrecerContext context)
        {
            _context = context;
        }

        // GET: api/TipoAfiliaciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoAfiliacion>>> GetTipoAfiliacion()
        {
            return await _context.TipoAfiliacion.ToListAsync();
        }

        // GET: api/TipoAfiliaciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoAfiliacion>> GetTipoAfiliacion(int id)
        {
            var tipoAfiliacion = await _context.TipoAfiliacion.FindAsync(id);

            if (tipoAfiliacion == null)
            {
                return NotFound();
            }
            return tipoAfiliacion;
        }

        // PUT: api/TipoAfiliaciones/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoAfiliacion(int id, TipoAfiliacion tipoAfiliacion)
        {
            if (id != tipoAfiliacion.ID)
            {
                return BadRequest();
            }

            _context.Entry(tipoAfiliacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoAfiliacionExists(id))
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

        // POST: api/TipoAfiliaciones
        [HttpPost]
        public async Task<ActionResult<TipoAfiliacion>> PostTipoAfiliacion(TipoAfiliacion tipoAfiliacion)
        {
            _context.TipoAfiliacion.Add(tipoAfiliacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoAfiliacion", new { id = tipoAfiliacion.ID }, tipoAfiliacion);
        }

        // DELETE: api/TipoAfiliaciones/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TipoAfiliacion>> DeleteTipoAfiliacion(int id)
        {
            var tipoAfiliacion = await _context.TipoAfiliacion.FindAsync(id);
            if (tipoAfiliacion == null)
            {
                return NotFound();
            }

            _context.TipoAfiliacion.Remove(tipoAfiliacion);
            await _context.SaveChangesAsync();

            return tipoAfiliacion;
        }
        private bool TipoAfiliacionExists(int id)
        {
            return _context.TipoAfiliacion.Any(e => e.ID == id);
        }
    }
}
