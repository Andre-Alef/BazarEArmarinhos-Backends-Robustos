using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Models
{
   public class FornecedoresModel
    {
        public string Nomefornecedor { get; set; }
        public string Cnpj { get; set; }
        public string Produtoentregue { get; set; }
        public string Telefonefornecedor { get; set; }
        public string Telefonefornecedor2 { get; set; }
        public double Precoprodutoforn { get; set; }
        public int QuantidadeprodutoF { get; set; }
        public string DataentregaF { get; set; }
        public string Emailfornecedor { get; set; }
        public string Representante { get; set; }
        public Guid IdFornecedor { get; set; }

    }
}
