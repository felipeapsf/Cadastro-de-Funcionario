using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Mappings
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario");
            builder.HasKey(f => f.IdFuncionario);

            builder.Property(f => f.IdFuncionario)
                .HasColumnName("IdFuncionario");

            builder.Property(f => f.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(f => f.Salario)
                .HasColumnName("Salario")
                .HasColumnType("decimal(18,2)")                
                .IsRequired();

            builder.Property(f => f.DataAdmissao)
                .HasColumnName("DataAdmissao")
                .HasColumnType("date")
                .IsRequired();

            builder.Property(f => f.Cargo)
                .HasColumnName("Cargo")
                .HasMaxLength(250)
                .IsRequired();
        }
    }
}
