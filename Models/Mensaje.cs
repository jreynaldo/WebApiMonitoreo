using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonitoreoWhatsapp.Models
{
    [Table("mensajes")]
    public class Mensaje
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Usuario")]
        public int UsuarioID { get; set; }
        [ForeignKey("Grupo")]
        public int GrupoId { get; set; }
        public string Tipo { get; set; }
        [Display(Name = "Fecha")]
        public DateTime fecha { get; set; }
        [Display(Name = "Mensaje")]
        public string Descripcion { get; set; }
        public Usuario Usuario { get; set; }
        public Grupo Grupo { get; set; }

    }
}
