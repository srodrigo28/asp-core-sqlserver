using AspCoreExemplo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspCoreExemplo.EntityConfigs;

public class ClienteEntityConfig: IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("clientes");

        builder.Property(cliente => cliente.Id)
            .HasColumnName("id")
            .HasColumnType("int");
        builder.HasKey(cliente => cliente.Id);

        builder.Property(cliente => cliente.Nome)
            .IsRequired()
            .HasColumnName("nome")
            .HasColumnType("varchar(100)")
            .HasMaxLength(100);
        
        builder.Property(cliente => cliente.Cpf)
            .IsRequired()
            .HasColumnName("cpf")
            .HasColumnType("varchar(15)")
            .HasMaxLength(15);
    }
}