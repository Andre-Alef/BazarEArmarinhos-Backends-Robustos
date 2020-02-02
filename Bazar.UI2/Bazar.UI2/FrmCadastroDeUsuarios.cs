using Bazar.Domain.Contracts.Services;
using Bazar.Models;
using Bazar.StartUp;
using System;
using System.Windows.Forms;
using Unity;

namespace Bazar.UI2
{

    public partial class FrmCadastroDeUsuarios : Form
    {
        UserModel model = new UserModel();
        public FrmCadastroDeUsuarios()
        {
            InitializeComponent();
        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            var container = new UnityContainer();
            DependencyResolver.Resolve(container);

            var service = container.Resolve<IUserService>();
            model.Login = txtNomeUsuario.Text;
            model.Password = txtSenha.Text;
            model.ConfirmPassword = txtConfirmacao.Text;
         
          
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
