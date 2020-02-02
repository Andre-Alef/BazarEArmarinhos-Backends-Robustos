using Bazar.Common.Resources;
using Bazar.Common.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Models
{
   public class ProdutosDTO
    {
        #region Ctor

        protected ProdutosDTO() { }

        public ProdutosDTO(string nome, string tipo, double preco, int quantidade, string descricao)
        {
           //  this.IdProduto = IdProduto;
            this.NomeProduto = nome;
            this.TipoProduto = tipo;
            this.PrecoProduto = preco;
            this.QuantidadeProduto = quantidade;
            this.DescricaoProduto = descricao;

        }

        #endregion

        #region Properties
        public string NomeProduto { get; private set; }
       public string TipoProduto { get; private set; }
       public double PrecoProduto { get; private set; }
       public int QuantidadeProduto { get; private set; }
       public string DescricaoProduto { get; private set; }
        [Key]
        public int IdProduto { get; private set; }

        #endregion

        #region Methods

        public void ChangeField(string nome, string tipo, double preco, int quantidade, string descricao)
        {

            this.NomeProduto = nome;
            this.TipoProduto = tipo;
            this.PrecoProduto = preco;
            this.QuantidadeProduto = quantidade;
            this.DescricaoProduto = descricao;
        }



        public void Validate()
        {
            AssertionConcern.AssertArgumentLength(this.NomeProduto, 3, 60, Errors.InvalidUserName);
            AssertionConcern.AssertArgumentLength(this.TipoProduto, 3, 60, Errors.InvalidUserName);
            AssertionConcern.AssertArgumentLength(this.DescricaoProduto, 3, 240, Errors.InvalidUserName);

            AssertionConcern.AssertArgumentNotNull(this.NomeProduto, Errors.NotNull);
            AssertionConcern.AssertArgumentNotNull(this.TipoProduto, Errors.NotNull);
            AssertionConcern.AssertArgumentNotNull(this.PrecoProduto, Errors.NotNull);
            AssertionConcern.AssertArgumentNotNull(this.QuantidadeProduto, Errors.NotNull);
            AssertionConcern.AssertArgumentNotNull(this.DescricaoProduto, Errors.NotNull);





        }


        #endregion
    }
}
