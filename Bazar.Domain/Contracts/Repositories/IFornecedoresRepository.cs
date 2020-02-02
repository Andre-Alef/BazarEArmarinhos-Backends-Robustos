using System;
using System.Collections.Generic;
using Bazar.Models;
namespace Bazar.Domain.Contracts.Repositories
{
   public interface IFornecedoresRepository:IDisposable
    {

        List<FornecedoresDTO> Get(string nome);

        FornecedoresDTO Get(int Id);

        void Create(FornecedoresDTO fornecedores);

        void Update(FornecedoresDTO fornecedores);

        void Delete(FornecedoresDTO fornecedores);


    }
}
