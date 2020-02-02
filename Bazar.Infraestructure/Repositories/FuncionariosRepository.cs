using Bazar.Domain.Contracts.Repositories;
using Bazar.Infraestructure.Data;
using Bazar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Infraestructure.Repositories
{
    public class FuncionariosRepository : IFuncionariosRepository
    {
        private AppDataContext _Context;

        public FuncionariosRepository(AppDataContext context)
        {
            this._Context = context;
        }


        public void Create(FuncionariosDTO funcionarios)
        {
            _Context.Funcionarios.Add(funcionarios);
            _Context.SaveChanges();
        }

        public void Delete(FuncionariosDTO funcionarios)
        {

            _Context.Entry(funcionarios).State = System.Data.Entity.EntityState.Deleted;
            //   _Context.Usuarios.Remove(user);
            _Context.SaveChanges();
        }

      

        public List<FuncionariosDTO> Get(string nome)
        {
            return _Context.Funcionarios.ToList();
        }

        public FuncionariosDTO Get(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Update(FuncionariosDTO funcionarios)
        {

            _Context.Entry<FuncionariosDTO>(funcionarios).State = System.Data.Entity.EntityState.Modified;

            _Context.SaveChanges();

        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
