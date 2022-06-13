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
    public class AdminController : ControllerBase
    {
        public AdminUseCase CreateService()
        {
            PlantillaBD db = new PlantillaBD();
            AdminRepository repository = new AdminRepository(db);
            AdminUseCase service = new AdminUseCase(repository);
            return service;

        }

        // GET: api/<AdminController>
        [HttpGet]
        public ActionResult<IEnumerable<Administrador>> Get()
        {
            AdminUseCase service = CreateService();
            return Ok(service.GetAll());
        }

        // GET api/<AdminController>/5
        [HttpGet("{id}")]
        public ActionResult<Administrador> Get(Guid id)
        {
            AdminUseCase service = CreateService();
            return Ok(service.GetById(id));
        }

        // POST api/<AdminController>
        [HttpPost]
        public ActionResult<Administrador> Post([FromBody] Administrador usuario)
        {
            AdminUseCase service = CreateService();
            var result = service.Create(usuario);
            return Ok(result);
        }

        // PUT api/<AdminController>/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] Administrador usuario)
        {
            AdminUseCase service = CreateService();
            usuario.Id_Admin = id;
            service.Update(usuario);
            return Ok("Editado exitosamente");
        }

        // DELETE api/<AdminController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            AdminUseCase service = CreateService();
            service.Delete(id);
            return Ok("Eliminado Exitosamente");
        }
    }
}
