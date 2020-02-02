using Bazar.Common.Resources;
using Bazar.Domain.Contracts.Repositories;
using Bazar.Domain.Contracts.Services;
using Bazar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Business.Services
{
    public class ClientesService : IClientesService
    {

        private IClientesRepository _repository;

        public ClientesService(IClientesRepository repository)
        {
            _repository = repository;
        }
        


        public void ChangeInformation(ClientesDTO client)
        {
            _repository.Update(client);

        }


        public List<ClientesDTO> GetByNome(ClientesModel model)
        {
            var user = _repository.Get(model.NomeCliente);
            if (user == null)
                throw new Exception(Errors.UserNotFound);

            return user;
        }

        public void Register(ClientesModel model)
        {
            var user = new ClientesDTO(model.NomeCliente, model.TelefoneCliente, model.CelularCliente, model.EmailCliente, model.EnderecoCliente, model.BairroCliente, model.NumeroCliente, model.CPFCliente);
           
            _repository.Create(user);
        }
        public void Dispose()
        {
            _repository.Dispose();
        }

        public void Delete(ClientesDTO client)
        {
            _repository.Delete(client);
        }
    }
}
