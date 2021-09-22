using curso.api.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace curso.api.Infraestruture.Data.Mappings
{
    public class CursoMapping : IEntityTypeConfiguration<Curso>
    {
        // configura o banco de dados
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            // tabela TB_CURSO
            builder.ToTable("TB_CURSO");
            builder.HasKey(p => p.Codigo); // primary key
            builder.Property(p => p.Codigo).ValueGeneratedOnAdd(); // gera id único
            builder.Property(p => p.Nome);
            builder.Property(p => p.Descricao);
            builder.HasOne(p => p.Usuario)
                .WithMany().HasForeignKey(fk => fk.CodigoUsuario); // foreign key com TB_USUARIO
        }
    }
}
