using JovemProgramadorMVC10.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JovemProgramadorMVC10.Data.Mapeamento
{
    public class AlunoMapeamento : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            //Definição da tabela no banco de dados
            builder.ToTable("Aluno");
            //Definição da chave primária na tabela
            builder.HasKey(t => t.Id);
            //Configuração das propriedades da entidade
            builder.Property(t => t.Matricula).HasColumnType("varchar(20)");
            builder.Property(t => t.Nome).HasColumnType("varchar(50)");
            builder.Property(t => t.Cpf).HasColumnType("varchar(14)");

        }
    }
}
