using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonitoreoWhatsapp.Models
{
    public class Usuario
    {
         public Usuario() { }
        [Key]
        public int Id { get; set; }
        [Display(Name = "Usuario")]
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public List<GrupoUsuario> GruposUsuarios { get; set; }
        public List<Mensaje> mensajes { get; set; }
    }
}
