using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AFPCrecer.Models;

namespace AFPCrecer.Models
{
    public class AFPCrecerContext : DbContext
    {
        public AFPCrecerContext (DbContextOptions<AFPCrecerContext> options)
            : base(options)
        {
        }

        public DbSet<AFPCrecer.Models.Persona> Persona { get; set; }

        public DbSet<AFPCrecer.Models.TipoAfiliacion> TipoAfiliacion { get; set; }

        public DbSet<AFPCrecer.Models.Afiliacion> Afiliacion { get; set; }
    }
}
