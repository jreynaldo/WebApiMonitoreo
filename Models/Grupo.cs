using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonitoreoWhatsapp.Models
{
    public class Grupo
    {
        public Grupo() { }
        [Key]
        public int Id { get; set; }
        [Display(Name ="Grupo")]
        public string Nombre { get; set; }
        public List<GrupoUsuario> GruposUsuarios { get; set; }
    }
}
