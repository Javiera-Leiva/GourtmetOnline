using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GourmetOnline.Core.Domain.Models;

namespace GourmetOnline.Adaptors.SQLServerDataAccess.Entities
{
    public class EModo_Pago : IEntityTypeConfiguration<Modo_Pago>
    {
        public void Configure(EntityTypeBuilder<Modo_Pago> builder)
        {
            builder.ToTable("tb_Modo_Pago");

            builder.HasKey(Mp => Mp.Id_Modo_Pago);

     
        }
    }
}
