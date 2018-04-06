using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonitoreoWhatsapp.Models
{
    public class GroupByUsuario
    {
        public Grupo Grupo { get; set; }
        public Usuario Usuario { get; set; }
        public int Total { get; set; }
    }
}
