using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiMonitoreo.Services;
using WebMonitoreoWhatsapp.Models;

namespace WebApiMonitoreo.Controllers
{
    [Produces("application/json")]
    [Route("api/Usuario")]
    public class UsuarioController : Controller
    {
        public IUsuarioService UsuarioService { get; set; }
        public UsuarioController(IUsuarioService usuarioService) {
            UsuarioService = usuarioService;
        }
        // GET: api/Usuario
        [HttpGet]
        public List<Usuario> Get()

        {

            return UsuarioService.GetAll();
        }

        // GET: api/Usuario/5
        [HttpGet("{id}", Name = "Get")]
        public Usuario Get(int id)
        {
            return UsuarioService.GetById(id);
        }

        [HttpGet("Nombre/{Nombre}", Name = "Nombre")]
        public Usuario Get(string Nombre)
        {
            return UsuarioService.GetByName(Nombre);
        }

        // POST: api/Usuario
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Usuario/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
