using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GourmetOnline.Core.Domain.Models;

namespace GourmetOnline.Adaptors.SQLServerDataAccess.Entities
{
    public class ECliente : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("tb_Cliente");

            builder.HasKey(C => C.Id_Cliente);

            builder
                .HasMany(P => P.Pedidos)
                .WithOne(PC => PC.Cliente);

            builder
              .HasMany(M => M.Menus)
              .WithOne(MC => MC.Cliente);

            builder
             .HasMany(M => M.Modo_pagos)
             .WithOne(DC => DC.Cliente);


        }
    }
}
