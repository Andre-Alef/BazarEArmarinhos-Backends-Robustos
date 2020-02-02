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

    public class FornecedoresService : IFornecedoresService
    {
        private IFornecedoresRepository _repository;

        public FornecedoresService(IFornecedoresRepository repository)
        {
            _repository = repository;
        }


        public void ChangeInformation(FornecedoresDTO forn)
        {
            _repository.Update(forn);
        }



        public List<FornecedoresDTO> GetByNome(FornecedoresModel model)
        {

            var user = _repository.Get(model.Nomefornecedor);
            if (user == null)
                throw new Exception(Errors.UserNotFound);

            return user;
        }

        public void Register(FornecedoresModel model)
        {
            var user = new FornecedoresDTO(model.Nomefornecedor,model.Cnpj,model.Produtoentregue,model.Telefonefornecedor,model.Telefonefornecedor2,model.Precoprodutoforn,model.QuantidadeprodutoF,model.DataentregaF,model.Emailfornecedor,model.Representante);
         

            _repository.Create(user);

        }

        public void Dispose()
        {
            _repository.Dispose();
        }


        public void Delete(FornecedoresDTO forn)
        {
            _repository.Delete(forn);
        }
    }
}
