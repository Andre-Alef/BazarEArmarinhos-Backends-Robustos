using Bazar.Models;
using System;
using System.Collections.Generic;

namespace Bazar.Domain.Contracts.Repositories
{
    public interface IProductRepository: IDisposable
    {

        List<ProdutosDTO> Get(string nome);

        ProdutosDTO Get(int Id);

        void Create(ProdutosDTO produtos);

        void Update(ProdutosDTO produtos);

        void Delete(ProdutosDTO produtos);



    }
}
