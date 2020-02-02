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
    public class ProdutosRepository : IProductRepository
    {


        private AppDataContext _Context;

        public ProdutosRepository(AppDataContext context)
        {
            this._Context = context;
        }

        public ProdutosDTO Get(int Id)
        {
            return _Context.Produtos.Where(x => x.IdProduto == Id).FirstOrDefault();
        }

        public void Create(ProdutosDTO produtos)
        {
            _Context.Produtos.Add(produtos);
            _Context.SaveChanges();
        }

        public void Delete(ProdutosDTO produtos)
        {

            _Context.Entry(produtos).State = System.Data.Entity.EntityState.Deleted;
            //   _Context.Usuarios.Remove(user);
            _Context.SaveChanges();
        }


        public List<ProdutosDTO> Get(string nome)
        {
            return _Context.Produtos.ToList();
        }
    

      

        public void Update(ProdutosDTO produtos)
        {
            _Context.Entry<ProdutosDTO>(produtos).State = System.Data.Entity.EntityState.Modified;

            _Context.SaveChanges();



        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
