using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonitoreoWhatsapp.Models
{
    public class TotalByUsuario
    {
        public Usuario Usuario { get; set; }
        public List<GrupoTotal> GruposTotal { get; set; }
    }
}
