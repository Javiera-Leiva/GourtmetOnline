using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using GourmetOnline.Core.Domain.Models;

using GourmetOnline.Adaptors.SQLServerDataAccess.Entities;

using GourmetOnline.Adaptors.SQLServerDataAccess.Utils;


namespace GourmetOnline.Adaptors.SQLServerDataAccess.Contexts
{
  
        public class PlantillaDB : DbContext
    {
        public DbSet<Administrador> administrador { get; set; }
        public DbSet<Bebida> bebida { get; set; }
        public DbSet<Categoria> categoria { get; set; }
        public DbSet<Cliente> cliente { get; set; }

        public DbSet<Descripcion_Bebida> descripcion_Bebida { get; set; }

        public DbSet<Descripcion_Plato> descripcion_Plato { get; set; }

        public DbSet<Menu> menu { get; set; }

        public DbSet<Modo_Pago> modo_Pago { get; set; }

        public DbSet<Pedido> pedido { get; set; }

        public DbSet<Plato> plato { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new EAdministrador());
            builder.ApplyConfiguration(new EBebida());
            builder.ApplyConfiguration(new ECategoria());
            builder.ApplyConfiguration(new ECliente());
            builder.ApplyConfiguration(new EDescripcionBebida());
            builder.ApplyConfiguration(new EDescripcion_Plato());
            builder.ApplyConfiguration(new EMenu());
            builder.ApplyConfiguration(new EModo_Pago());
            builder.ApplyConfiguration(new EPedido());
            builder.ApplyConfiguration(new EPlato());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(GlobalSetting.SqlServerConnectionString);
        }
    }
}




