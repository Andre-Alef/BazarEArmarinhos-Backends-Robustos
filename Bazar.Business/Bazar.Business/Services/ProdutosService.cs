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
  public class ProdutosService : IProdutosService
    {

        private IProductRepository _repository;

        public ProdutosService(IProductRepository repository)
        {
            _repository = repository;
        }


        public void ChangeInformation(ProdutosDTO prod)
        {

            _repository.Update(prod);

        }

        public void Delete(ProdutosDTO prod)
        {
            _repository.Delete(prod);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public List<ProdutosDTO> GetByNome(FuncionariosModel model)
        {
            var prod = _repository.Get(model.NomeFuncionario);
            if (prod == null)
                throw new Exception(Errors.UserNotFound);

            return prod;
        }

        public void Register(ProdutosModel model)
        {
            var produtos = new ProdutosDTO(model.NomeProduto, model.TipoProduto, model.PrecoProduto, model.QuantidadeProduto, model.DescricaoProduto);
            _repository.Create(produtos);
        }
    }
}
