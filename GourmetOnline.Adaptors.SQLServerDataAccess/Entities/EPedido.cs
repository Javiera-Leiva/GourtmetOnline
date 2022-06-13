using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GourmetOnline.Core.Domain.Models;

namespace GourmetOnline.Adaptors.SQLServerDataAccess.Entities
{
    public class EPedido : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("tb_Pedido");

            builder.HasKey(pd => pd.Id_Pedido);

       
        }
    }
}
