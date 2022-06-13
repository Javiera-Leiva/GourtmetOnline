using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GourmetOnline.Core.Domain.Models;

namespace GourmetOnline.Adaptors.SQLServerDataAccess.Entities
{
    public class ECategoria : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("tb_Categoria");

            builder.HasKey(CT => CT.Id_Categoria);

        }
    }
}
