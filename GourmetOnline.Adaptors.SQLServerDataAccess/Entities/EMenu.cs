using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GourmetOnline.Core.Domain.Models;

namespace GourmetOnline.Adaptors.SQLServerDataAccess.Entities
{
    public class EMenu : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("tb_Menu");

            builder.HasKey(m => m.Id_Menu);

            builder
                .HasMany(P => P.Plato)
                .WithOne(Pm => Pm.Menu);

            builder
                .HasMany(P => P.Bebida)
                .WithOne(Pm => Pm.Menu);


        }
        }
    }

