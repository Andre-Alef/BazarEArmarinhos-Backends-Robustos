using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Models
{
   public class ClientesModel
    {
        public string NomeCliente { get; set; }
        public string TelefoneCliente { get; set; }
        public string CelularCliente { get; set; }
        public string EmailCliente { get; set; }
        public string EnderecoCliente { get; set; }
        public string BairroCliente { get; set; }
        public string NumeroCliente { get; set; }
        public string CPFCliente { get; set; }
        public Guid IdCliente { get; set; }


    }
}
