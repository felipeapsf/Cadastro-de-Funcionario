using Projeto.Data.Context;
using Projeto.Data.Contracts;
using Projeto.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Repositories
{
    public class FuncionarioRepository : BaseRepository<Funcionario>, IFuncionarioRepository
    {
        //atributo
        private readonly DataContext context;

        //construtor para injeção de dependência
        public FuncionarioRepository(DataContext context) : base(context) //construtor da superclasse
        {
            this.context = context;
        }
    }
}
