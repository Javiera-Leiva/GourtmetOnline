using System;
using System.Collections.Generic;
using System.Text;
using GourmetOnline.Core.Domain.Models;
using GourmetOnline.Core.Infraestructure.Repository.Abstract;
using GourmetOnline.Adaptors.SQLServerDataAccess.Contexts;
using System.Linq;

namespace GourmetOnline.Core.Infraestructure.Repository.Concrete
{
    public class AdminRepository : IBaseRepository<Administrador, Guid>
    {
        private PlantillaDB db;
        public AdminRepository(PlantillaDB db)
        {
            this.db = db;
        }

        public Administrador Create(Administrador administrador)
        {
            administrador.Id_Admin = Guid.NewGuid();
            db.administrador.Add(administrador);
            return administrador;
        }

        public void Delete(Guid entityId)
        {
            var SelectedAdmin = db.administrador
              .Where(a => a.Id_Admin == entityId).FirstOrDefault();
            if (SelectedAdmin != null)
                db.administrador.Remove(SelectedAdmin);
        }

        public List<Administrador> GetAll()
        {
            return db.administrador.ToList();
        }

        public Administrador GetById(Guid entityId)
        {
            var SelectedAdmin = db.administrador
             .Where(a => a.Id_Admin == entityId).FirstOrDefault();
            return SelectedAdmin;
        }


        public void saveAllChanges()
        {
            db.SaveChanges();
        }

        public Administrador Update(Administrador administrador)
        {
            var selectedAdmin = db.administrador
             .Where(a => a.Id_Admin == administrador.Id_Admin).FirstOrDefault();

            if (selectedAdmin != null)
            {
                selectedAdmin.Nombre_Admin = administrador.Nombre_Admin;
                selectedAdmin.Correo_Admin = administrador.Correo_Admin;
                selectedAdmin.Telefono = administrador.Telefono;
                selectedAdmin.Contraseña = administrador.Contraseña;

                db.Entry(selectedAdmin).State =
                    Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            return selectedAdmin;
        }
    }
}
