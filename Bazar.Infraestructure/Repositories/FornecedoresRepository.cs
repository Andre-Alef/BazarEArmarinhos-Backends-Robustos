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
    public class FornecedoresRepository : IFornecedoresRepository
    {

        private AppDataContext _Context;

        public FornecedoresRepository(AppDataContext context)
        {
            this._Context = context;
        }

        public void Create(FornecedoresDTO fornecedores)
        {
            _Context.Fornecedores.Add(fornecedores);
            _Context.SaveChanges();
        }

        public void Delete(FornecedoresDTO fornecedores)
        {

            _Context.Entry(fornecedores).State = System.Data.Entity.EntityState.Deleted;
            //   _Context.Usuarios.Remove(user);
            _Context.SaveChanges();
        }

     

        public List<FornecedoresDTO> Get(string nome)
        {
            return _Context.Fornecedores.ToList();
        }

        public FornecedoresDTO Get(int Id)
        {
            return _Context.Fornecedores.Where(x => x.IdFornecedor == Id).FirstOrDefault();
        }

        public void Update(FornecedoresDTO fornecedores)
        {

            _Context.Entry<FornecedoresDTO>(fornecedores).State = System.Data.Entity.EntityState.Modified;

            _Context.SaveChanges();


        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
