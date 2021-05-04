using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome).IsRequired().HasMaxLength(60);
            builder.HasIndex(u => u.Cpf).IsUnique();
            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.Telefone).IsRequired();
            builder.Property(u => u.Sexo).IsRequired();
            builder.Property(u => u.DataNascimento).IsRequired();
        }
    }
}