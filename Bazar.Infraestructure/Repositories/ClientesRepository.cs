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
    public class ClientesRepository : IClientesRepository
    {

        private AppDataContext _Context;

        public ClientesRepository(AppDataContext context)
        {
            this._Context = context;
        }


        public List<ClientesDTO> Get(string nome)
        {
            return _Context.Clientes.ToList();
        }

        public ClientesDTO Get(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Update(ClientesDTO clientes)
        {

            _Context.Entry<ClientesDTO>(clientes).State = System.Data.Entity.EntityState.Modified;

            _Context.SaveChanges();


        }


        public void Create(ClientesDTO clientes)
        {
            _Context.Clientes.Add(clientes);
            _Context.SaveChanges();
        }

        public void Delete(ClientesDTO clientes)
        {
            _Context.Entry(clientes).State = System.Data.Entity.EntityState.Deleted;
            //   _Context.Usuarios.Remove(user);
            _Context.SaveChanges();

        }



        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
