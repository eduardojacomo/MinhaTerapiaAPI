using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using minhaterapia.Models;

namespace minhaterapia.Data.Map;

public class TerapiaMap : IEntityTypeConfiguration<TerapiaModel>
{
    public void Configure(EntityTypeBuilder<TerapiaModel> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.CodigoPaciente).IsRequired().HasMaxLength(10);
        builder.Property(x => x.CodigoProfissional).IsRequired().HasMaxLength(10);
        builder.Property(x => x.Status).IsRequired();
    }
}
