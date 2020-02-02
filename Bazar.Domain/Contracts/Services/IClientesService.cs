using Bazar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Domain.Contracts.Services
{
   public interface IClientesService:IDisposable
    {

        List<ClientesDTO> GetByNome(ClientesModel model);

        void Register(ClientesModel model);

        void ChangeInformation(ClientesDTO client);

        void Delete(ClientesDTO client);

    }
}
