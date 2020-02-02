using Bazar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Domain.Contracts.Repositories
{
   public interface IFuncionariosRepository: IDisposable
    {
        List<FuncionariosDTO> Get(string nome);

        FuncionariosDTO Get(Guid Id);

        void Create(FuncionariosDTO funcionarios);

        void Update(FuncionariosDTO funcionarios);

        void Delete(FuncionariosDTO funcionarios);


    }
}
