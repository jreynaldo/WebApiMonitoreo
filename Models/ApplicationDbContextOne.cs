using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonitoreoWhatsapp.Models
{
    public class ApplicationDbContextOne : DbContext
    {

        public ApplicationDbContextOne(DbContextOptions <ApplicationDbContextOne> options):base(options)
        {

        }

      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GrupoUsuario>().HasKey(x => new { x.GrupoId, x.UsuarioId });
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Mensaje> Mensajes { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<GrupoUsuario> GruposUsuarios { get; set; }
    }
}
