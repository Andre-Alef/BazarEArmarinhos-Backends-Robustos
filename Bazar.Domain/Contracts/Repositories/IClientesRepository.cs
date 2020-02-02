using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bazar.Models;

namespace Bazar.Domain.Contracts.Repositories
{
   public interface IClientesRepository:IDisposable
    {

        List<ClientesDTO> Get(string nome);

        ClientesDTO Get(Guid Id);

        void Create(ClientesDTO clientes);

        void Update(ClientesDTO clientes);

        void Delete(ClientesDTO clientes);




    }
}
