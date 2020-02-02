using System;
using System.Windows.Forms;
using Bazar.Business;
namespace Bazar.UI2
{
    public partial class FrmCadastroTelinha : Form
    {
        UtilidadesComuns utilidades = new UtilidadesComuns();

        public FrmCadastroTelinha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           utilidades.OpenForm((typeof(FrmCadastroClientes)));
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           utilidades.OpenForm((typeof(FrmCadastroFornecedores)));
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            utilidades.OpenForm((typeof(FrmCadastroProdutos)));
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            utilidades.OpenForm((typeof(FrmCadastroDeUsuarios)));
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            utilidades.OpenForm((typeof(FrmCadastroFuncionarios)));
            
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
