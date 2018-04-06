using System.Collections.Generic;
using WebMonitoreoWhatsapp.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApiMonitoreo.Services
{
    public interface IUsuarioService
    {
         List<Usuario> GetAll();
         Usuario GetById(int Id);
        Usuario GetByName(string Nombre);
    }

    public class UsuarioService : IUsuarioService
    {
        private readonly ApplicationDbContextOne _context;

        public UsuarioService(ApplicationDbContextOne context)
        {
            _context = context;
        }
        public List<Usuario> GetAll()
        {
            return _context.Usuarios.ToList();
        }
        public Usuario GetById(int Id) {
            return _context.Usuarios.Single(x => x.Id == Id);
        }

        public Usuario GetByName(string Nombre)
        {
            return _context.Usuarios.Single(x => x.Nombre == Nombre);
        }
    }
}