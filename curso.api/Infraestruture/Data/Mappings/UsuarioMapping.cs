using curso.api.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace curso.api.Infraestruture.Data.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            // tabela TB_USUARIO
            builder.ToTable("TB_USUARIO");
            builder.HasKey(p => p.Codigo); // primary key
            builder.Property(p => p.Codigo).ValueGeneratedOnAdd(); // gera id_único
            builder.Property(p => p.Login);
            builder.Property(p => p.Senha);
            builder.Property(p => p.Email);
        }
    }
}
