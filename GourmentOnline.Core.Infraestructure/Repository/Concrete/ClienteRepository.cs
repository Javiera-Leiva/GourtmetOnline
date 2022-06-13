using System;
using System.Collections.Generic;
using GourmetOnline.Core.Domain.Models;
using GourmetOnline.Core.Infraestructure.Repository.Abstract;
using GourmetOnline.Adaptors.SQLServerDataAccess.Contexts;
using System.Linq;


namespace GourmetOnline.Core.Infraestructure.Repository.Concrete
{
    public class ClienteRepository : IBaseRepository<Cliente, Guid>
    {
        private PlantillaDB db;
        public ClienteRepository(PlantillaDB db)
        {
            this.db = db;
        }

        public Cliente Create(Cliente cliente)
        {
            cliente.Id_Cliente = Guid.NewGuid();
            db.cliente.Add(cliente);
            return cliente;
        }

        public void Delete(Guid entityId)
        {
            var SelectedCliente = db.cliente
              .Where(a => a.Id_Cliente == entityId).FirstOrDefault();
                 if (SelectedCliente != null)
                db.cliente.Remove(SelectedCliente);
        }

        public List<Cliente> GetAll()
        {
            return db.cliente.ToList();
        }

        public Cliente GetById(Guid entityId)
        {
            var SelectedCliente = db.cliente
            .Where(a => a.Id_Cliente == entityId).FirstOrDefault();
            return SelectedCliente;
        }

        public void saveAllChanges()
        {
            db.SaveChanges();
        }

        public Cliente Update(Cliente cliente)
        {
            var selectedCliente = db.cliente
            .Where(a => a.Id_Cliente == cliente.Id_Cliente).FirstOrDefault();

            if (selectedCliente != null)
            {
                selectedCliente.Nombre = cliente.Nombre;
                selectedCliente.Correo = cliente.Correo;
                selectedCliente.Telefono = cliente.Telefono;
                selectedCliente.Contraseña = cliente.Contraseña;

                db.Entry(selectedCliente).State =
                    Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            return selectedCliente;
        }

    }
}
