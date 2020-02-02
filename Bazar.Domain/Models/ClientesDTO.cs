using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Models
{
   public class ClientesDTO
    {
        public ClientesDTO()
        {
                
        }

        public ClientesDTO(string nome, string tel, string cel, string email, string endereco, string bairro, string numero, string cpf)
        {
            this.NomeCliente = nome;
            this.TelefoneCliente = tel;
            this.CelularCliente = cel;
            this.EmailCliente = email;
            this.EnderecoCliente = endereco;
            this.BairroCliente = bairro;
            this.NumeroCliente = numero;
            this.CPFCliente = cpf;
            this.IdCliente = IdCliente;


        }

       public string NomeCliente { get; set; }
       public string TelefoneCliente { get;  set; }
       public string CelularCliente { get;  set; }
       public string EmailCliente { get; set; }
       public string EnderecoCliente { get;  set; }
       public string BairroCliente { get;  set; }
       public string NumeroCliente { get;  set; }
       public string CPFCliente { get; set; }
        [Key]
        public int IdCliente { get;  set; }
      
    }
}
