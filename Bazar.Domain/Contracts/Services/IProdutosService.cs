using Bazar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Domain.Contracts.Services
{
   public interface IProdutosService: IDisposable
    {
        
        List<ProdutosDTO> GetByNome(FuncionariosModel model);

        void Register(ProdutosModel model);

        void ChangeInformation(ProdutosDTO prod);

        void Delete(ProdutosDTO prod);
    }
}
