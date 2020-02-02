using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Models
{
    public class FornecedoresDTO
    {
        public FornecedoresDTO()
        {

        }

        public FornecedoresDTO(string nomeF, string cnpj, string produto, string telF, string telF2, double precoP, int quantidadeP,
            string data, string emailF, string representante)
        {
            this.Nomefornecedor = nomeF;
            this.Cnpj = cnpj;
            this.Produtoentregue = produto;
            this.Telefonefornecedor = telF;
            this.Telefonefornecedor2 = telF2;
            this.Precoprodutoforn = precoP;
            this.QuantidadeprodutoF = quantidadeP;
            this.DataentregaF = data;
            this.Emailfornecedor = emailF;
            this.Representante = representante;
      //      this.IdFornecedor = IdFornecedor;
            

        }


        public string Nomefornecedor { get; set; }
        public string Cnpj { get;  set; }
        public string Produtoentregue { get;  set; }
        public string Telefonefornecedor { get;  set; }
        public string Telefonefornecedor2 { get;  set; }
        public double Precoprodutoforn { get;  set; }
        public int QuantidadeprodutoF { get; set; }
        public string DataentregaF { get;set; }
        public string Emailfornecedor { get;set; }
        public string Representante { get; set; }
        [Key]
        public int IdFornecedor { get;  set; }

    }
}
