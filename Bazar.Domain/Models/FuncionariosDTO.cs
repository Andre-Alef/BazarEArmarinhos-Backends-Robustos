using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Models
{
   public class FuncionariosDTO
    {
        #region Ctor

        protected FuncionariosDTO() {  }

        public FuncionariosDTO(string nome, int idade, string rg, string cpf, string sexo, string endereco, 
            string bairro, string telefone, string celular, string funcao, double salario)
        {
            this.NomeFuncionario = nome;
            this.IdadeFuncionario = idade;
            this.RGFuncionario = rg;
            this.CPFfuncionario = cpf;
            this.SexoFuncionario = sexo;
            this.EnderecoFuncionario = endereco;
            this.BairroFuncionario = bairro;
            this.TelefoneFuncionario = telefone;
            this.CelularFuncinario = celular;
            this.FuncaoFuncionario = funcao;
            this.SalarioFuncionario = salario;

        }

        #endregion
        public string NomeFuncionario { get; private set; }
       public int IdadeFuncionario { get; private set; }
       public string RGFuncionario { get; private set; } 
       public string CPFfuncionario { get; private set; } 
       public string SexoFuncionario { get; private set; }  
       public string EnderecoFuncionario { get; private set; } 
       public string BairroFuncionario { get; private set; } 
       public string TelefoneFuncionario { get; private set; }
       public string CelularFuncinario { get; private set; }
       public string FuncaoFuncionario { get; private set; } 
       public double SalarioFuncionario { get; private set; }
        [Key]
        public int IdFuncionario { get; private set; }

    }
}
