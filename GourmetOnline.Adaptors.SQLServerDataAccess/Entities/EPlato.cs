using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GourmetOnline.Core.Domain.Models;


namespace GourmetOnline.Adaptors.SQLServerDataAccess.Entities
{
    public class EPlato : IEntityTypeConfiguration<Plato>
    {
        public void Configure(EntityTypeBuilder<Plato> builder)
        {
            builder.ToTable("tb_Plato");

            builder.HasKey(Pl => Pl.Id_Plato);

            builder
                .HasMany(P => P.Descripcion_Platos)
                .WithOne(PD => PD.Plato);

        
        }
    }
}
