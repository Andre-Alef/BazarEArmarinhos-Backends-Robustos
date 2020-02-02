using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Models
{
   public class ProdutosModel
    {

        public string NomeProduto { get; set; }

        public string TipoProduto { get; set; }

        public double PrecoProduto { get; set; }

        public int QuantidadeProduto { get; set; }

        public string DescricaoProduto { get; set; }

        public Guid IdProduto { get; set; }

    }
}
