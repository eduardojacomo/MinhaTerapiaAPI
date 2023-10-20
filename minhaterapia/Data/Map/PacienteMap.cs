using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using minhaterapia.Models;

namespace minhaterapia.Data.Map;

public class PacienteMap : IEntityTypeConfiguration<PacientesModel>
{
    public void Configure(EntityTypeBuilder<PacientesModel> builder)
    {
        builder.HasKey(x => x.ID);
        builder.Property(x => x.Nome).IsRequired().HasMaxLength(128);
        builder.Property(x => x.CPF).IsRequired().HasMaxLength(14);
        builder.Property(x => x.Sexo).IsRequired().HasMaxLength(30);
        builder.Property(x => x.DataNascimento).IsRequired();
        builder.Property(x => x.CEP).IsRequired().HasMaxLength(10);
        builder.Property(x => x.Endereco).IsRequired().HasMaxLength(300);
        builder.Property(x => x.Numero).IsRequired().HasMaxLength(8);
        builder.Property(x => x.Complemento).HasMaxLength(80);
        builder.Property(x => x.Bairro).IsRequired().HasMaxLength(80);
        builder.Property(x => x.Cidade).IsRequired().HasMaxLength(60);
        builder.Property(x => x.UF).IsRequired().HasMaxLength(2);
        builder.Property(x => x.Celular).IsRequired().HasMaxLength(20);
        builder.Property(x => x.Email).IsRequired().HasMaxLength(60);
        builder.Property(x => x.Codigo).IsRequired().HasMaxLength(10);
        builder.Property(x => x.DataCadastro).IsRequired().HasMaxLength(40);
        builder.Property(x => x.DataAlteracao).IsRequired().HasMaxLength(40);
       
    }
}
