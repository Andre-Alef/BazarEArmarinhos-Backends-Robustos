using System;
using System.Windows.Forms;

using Bazar.Business;
using Bazar.Domain.Contracts.Services;
using Bazar.Models;
using Bazar.StartUp;
using Unity;

namespace Bazar.UI2
{
    public partial class FrmLogin : Form
    {
        FrmSplash Splash = new FrmSplash();
        UserModel model = new UserModel();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            var container = new UnityContainer();
            DependencyResolver.Resolve(container);

            var service = container.Resolve<IUserService>();
            model.Login = txtlogin.Text;
            model.Password = txtsenha.Text;

            try
            {

                

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

