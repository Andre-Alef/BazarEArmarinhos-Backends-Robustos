using Bazar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Domain.Contracts.Services
{
   public interface IFuncionariosService:IDisposable
    {

        List<FuncionariosDTO> GetByNome(FuncionariosModel model);

        void Register(FuncionariosModel model);

        void ChangeInformation(FuncionariosDTO func);

        void Delete(FuncionariosDTO func);

    }
}
