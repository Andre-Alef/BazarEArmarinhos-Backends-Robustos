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
    public partial class FrmCadastroFuncionarios : Form
    {
        FuncionariosModel model = new FuncionariosModel();
        public FrmCadastroFuncionarios()
        {
            InitializeComponent();
        }

        private void btnCadastrarFuncionarios_Click(object sender, EventArgs e)
        {
            var container = new UnityContainer();
            DependencyResolver.Resolve(container);

            var service = container.Resolve<IFuncionariosService>();
            model.NomeFuncionario = txtNomeFuncionario.Text;
            model.RGFuncionario = mtbRGfuncionario.Text;
         // model.SalarioFuncionario=  (double)mtbSalarioFuncionario.Text;
            model.SexoFuncionario = cboSexoFuncionario.Text;
            model.TelefoneFuncionario = mtbTelefoneFuncionario.Text;
            model.BairroFuncionario = txtBairroFuncionario.Text;
            model.CelularFuncinario = mtbCelularFuncionario.Text;
            model.CPFfuncionario = mtbCPFfuncionario.Text;
            model.EnderecoFuncionario = txtEnderecoFuncionario.Text;
            model.FuncaoFuncionario = cboFuncao.Text;
          //  model.IdadeFuncionario = txtIdadeFuncionario.Text;

            try
            {
                service.Register(model);
                MessageBox.Show("Funcionario cadastrado com sucesso!!", "Inserido com sucesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
