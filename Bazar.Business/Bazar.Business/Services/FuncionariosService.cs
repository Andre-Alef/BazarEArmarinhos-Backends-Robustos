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
    public class FuncionariosService : IFuncionariosService
    {
        private IFuncionariosRepository _repository;

        public FuncionariosService(IFuncionariosRepository repository)
        {
            _repository = repository;
        }

        
        public void ChangeInformation(FuncionariosDTO func)
        {
            _repository.Update(func);
        }

        public void Delete(FuncionariosDTO func)
        {
            _repository.Delete(func);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public List<FuncionariosDTO> GetByNome(FuncionariosModel model)
        {
            throw new NotImplementedException();
        }

        public void Register(FuncionariosModel model)
        {
            var func = new FuncionariosDTO(model.NomeFuncionario,model.IdadeFuncionario,model.RGFuncionario, model.CPFfuncionario, model.SexoFuncionario,model.EnderecoFuncionario,model.BairroFuncionario, model.TelefoneFuncionario,model.CelularFuncinario,model.FuncaoFuncionario,model.SalarioFuncionario);
           

            _repository.Create(func);
        }
    }
}
