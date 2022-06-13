using Microsoft.AspNetCore.Mvc;
using GourmetOnline.Adaptors.SQLServerDataAccess.Contexts;
using GourmetOnline.Core.Aplication.AdminCases;
using GourmetOnline.Core.Infraestructure.Repository.Concrete;
using GourmetOnline.Core.Domain.Models;

using System.Collections.Generic;
using System.Linq;

using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GourmetControles.Controllers
{



    [Route("api/[controller]")]
    [ApiController]


    public class ClienteController : ControllerBase
    {

        public ClienteUseCase CreateService()
        {
            PlantillaDB db = new PlantillaDB();
            ClienteRepository repository = new ClienteRepository(db);
            ClienteUseCase service = new ClienteUseCase(repository);
            return service;

        }
        // GET: api/<ClienteController>
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            ClienteUseCase service = CreateService();
            return Ok(service.GetAll());
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public ActionResult<Cliente> Get(Guid id)
        {
            ClienteUseCase service = CreateService();
            return Ok(service.GetById(id));
        }

        // POST api/<ClienteController>
        [HttpPost]
        public ActionResult<Cliente> Post([FromBody] Cliente usuario)
        {
            ClienteUseCase service = CreateService();
            var result = service.Create(usuario);
            return Ok(result);
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] Cliente usuario)
        {
            ClienteUseCase service = CreateService();
            usuario.Id_Cliente = id;
            service.Update(usuario);
            return Ok("Editado exitosamente");
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            ClienteUseCase service = CreateService();
            service.Delete(id);
            return Ok("Eliminado Exitosamente");
        }
    }
}