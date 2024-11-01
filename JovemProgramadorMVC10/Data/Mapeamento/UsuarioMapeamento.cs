using JovemProgramadorMVC10.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JovemProgramadorMVC10.Data.Mapeamento
{
    public class UsuarioMapeamento : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //Definição da tabela no banco de dados
            builder.ToTable("Usuario");
            //Definição da chave primária na tabela
            builder.HasKey(t => t.Id);
            //Configuração das propriedades da entidade
            builder.Property(t => t.Senha).HasColumnType("varchar(12)");
            builder.Property(t => t.Email).HasColumnType("varchar(50)");
        }
    }
}
