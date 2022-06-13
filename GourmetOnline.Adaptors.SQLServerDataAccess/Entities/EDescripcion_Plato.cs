using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GourmetOnline.Core.Domain.Models;



namespace GourmetOnline.Adaptors.SQLServerDataAccess.Entities
{
    public class EDescripcion_Plato : IEntityTypeConfiguration<Descripcion_Plato>
    {
        public void Configure(EntityTypeBuilder<Descripcion_Plato> builder)
        {
            builder.ToTable("tb_Descripcion_plato");

            builder.HasKey(d => d.Id_Tipo_Plato);
        }
    }
}
