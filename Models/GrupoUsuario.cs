using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonitoreoWhatsapp.Models
{
    public class GrupoUsuario
    {

        public int GrupoId { get; set; }

        public int UsuarioId { get; set; }
        public Grupo Grupo { get; set; }
        public Usuario Usuario { get; set; }
    }
}
