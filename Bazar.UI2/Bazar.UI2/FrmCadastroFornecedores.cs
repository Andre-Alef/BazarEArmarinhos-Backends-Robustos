using System;
using System.Drawing;
using System.Windows.Forms;
using Bazar.Business;
using Bazar.Domain.Contracts.Services;
using Bazar.Models;
using Bazar.StartUp;
using Unity;

namespace Bazar.UI2
{
    public partial class FrmCadastroFornecedores : Form
    {
        FornecedoresModel model = new FornecedoresModel();
        public FrmCadastroFornecedores()
        {
            InitializeComponent();
        }

        private void btnCadastrarForn_Click(object sender, EventArgs e)
        {
            var container = new UnityContainer();
            DependencyResolver.Resolve(container);

            var service = container.Resolve<IFornecedoresService>();
            model.Nomefornecedor = txtNomeFornecedor.Text;
           // model.Precoprodutoforn = txtPrecoPFornecedor.Text;
            model.Produtoentregue = txtProdutoFornecedor.Text;
            //model.QuantidadeprodutoF = txtQuantidadePFornecedor.Text;
            model.Representante = mstRepresentante.Text;
            model.Telefonefornecedor = txtTelefoneFornecedor.Text;
            model.Telefonefornecedor2 = txtTelefoneFornecedor2.Text;
            model.Cnpj = txtCNPJFornecedor.Text;
            model.DataentregaF = txtDataEntregaPF.Text;
            model.Emailfornecedor = txtEmailFornecedor.Text;


            try
            {
                service.Register(model);
                MessageBox.Show("Fornecedor cadastrado com sucesso!!", "Inserido com sucesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
