using Microsoft.EntityFrameworkCore;
using Projeto.Data.Entities;
using Projeto.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Context
{
    public class DataContext : DbContext
    {
        //construtor para receber a strind de conexão que será
        //enviada pela classe Startup.cs
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //adicionar cada classe de mapeamento do EntityFramework
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
        }

        //declarar uma propriedade DbSet para cada entidade
        public DbSet<Funcionario> Funcionario { get; set; }
    }
}
