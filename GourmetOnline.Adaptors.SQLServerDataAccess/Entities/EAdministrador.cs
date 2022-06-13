using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GourmetOnline.Core.Domain.Models;


namespace GourmetOnline.Adaptors.SQLServerDataAccess.Entities
{
    public class EAdministrador : IEntityTypeConfiguration<Administrador>
    {
        public void Configure(EntityTypeBuilder<Administrador> builder)
        {
            builder.ToTable("tb_Administrador");

            builder.HasKey(a => a.Id_Admin);

            builder
                .HasMany(a => a.Pedidos)

                .WithOne(ap => ap.Administrador);

            
        }
    }
}
