using System;
using System.Windows.Forms;
using Bazar.Business;
using Bazar.Domain.Contracts.Services;
using Bazar.Models;
using Bazar.StartUp;
using Unity;

namespace Bazar.UI2
{
    public partial class FrmCadastroProdutos : Form
    {
        ProdutosModel model = new ProdutosModel();
        public FrmCadastroProdutos()
        {
            InitializeComponent();
        }

        private void btnCadastrarProdutos_Click(object sender, EventArgs e)
        {
            var container = new UnityContainer();
            DependencyResolver.Resolve(container);


            var service = container.Resolve<IProdutosService>(); 
            model.NomeProduto = txtNomeProduto.Text;
           // model.PrecoProduto = double.TryParse(txtPrecoProduto.Text.ToString(), out of);
         //   model.QuantidadeProduto = (int)txtQuantidadeProduto.Text;
            model.TipoProduto = txtTipoProduto.Text;
            model.DescricaoProduto = txaDescricao.Text;

            try
            {
                service.Register(model);
                MessageBox.Show("Usuario Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                service.Dispose();
            }
        }
    }
}
