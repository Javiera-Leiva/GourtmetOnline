using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GourmetOnline.Core.Domain.Models;

namespace GourmetOnline.Adaptors.SQLServerDataAccess.Entities
{
    public class EBebida : IEntityTypeConfiguration<Bebida>
    {
        public void Configure(EntityTypeBuilder<Bebida> builder)
        {
            builder.ToTable("tb_Bebida");

            builder.HasKey(b => b.Id_Bebida);
                
            builder
                .HasMany(b => b.Descripcion_Bebida)
                .WithOne(bd=> bd.Bebida);


        }
    }
}
