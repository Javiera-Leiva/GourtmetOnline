using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GourmetOnline.Core.Domain.Models;

namespace GourmetOnline.Adaptors.SQLServerDataAccess.Entities
{
    public class EDescripcionBebida : IEntityTypeConfiguration<Descripcion_Bebida>
    {
        public void Configure(EntityTypeBuilder<Descripcion_Bebida> builder)
        {
            builder.ToTable("tb_Descripcion_Bebida");

            builder.HasKey(d => d.Id_Tipo_Bebida);


        }
    }
}
