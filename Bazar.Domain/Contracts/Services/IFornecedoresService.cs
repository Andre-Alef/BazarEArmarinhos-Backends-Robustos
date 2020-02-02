using Bazar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Domain.Contracts.Services
{
   public interface IFornecedoresService: IDisposable
    {


        List<FornecedoresDTO> GetByNome(FornecedoresModel model);

        void Register(FornecedoresModel model);

        void ChangeInformation(FornecedoresDTO forn);

        void Delete(FornecedoresDTO forn);

    }
}
