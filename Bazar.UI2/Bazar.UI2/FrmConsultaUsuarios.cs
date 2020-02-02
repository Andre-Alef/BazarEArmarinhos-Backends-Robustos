using System;
using System.Windows.Forms;
using Bazar.Business;

using Bazar.Domain.Contracts.Services;
using Bazar.Models;
using Bazar.StartUp;
using Unity;

namespace Bazar.UI2
{
    public partial class FrmConsultaUsuarios : Form
    {
      
        public FrmConsultaUsuarios()
        {
            InitializeComponent();
       
        }

        private void btnConsultarUsuario_Click(object sender, EventArgs e)
        {
            UserModel model = new UserModel();

            var container = new UnityContainer();
            DependencyResolver.Resolve(container);

            var service = container.Resolve<IUserService>();
            model.Login = TxtDesc.Text;
 
            try
            {
                var lista = service.GetByLogin(model); 
                var user = service.Authenticate(model);
                DgConsulta.DataSource = service.GetByLogin(model);
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

        private void FrmConsultaUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            UsuariosDTO user = new UsuariosDTO();

            var container = new UnityContainer();
            DependencyResolver.Resolve(container);


            var service = container.Resolve<IUserService>();
           user.Login = DgConsulta.SelectedCells[0].Value.ToString();
           user.Password = DgConsulta.SelectedCells[1].Value.ToString();
            DgConsulta.SelectedCells[2].ToString().ToUpper();
           user.IdUsuario = (int)DgConsulta.SelectedCells[2].Value;

            service.ChangeInformation(user);

        }

        private void DgConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DgConsulta.Rows[e.RowIndex].Cells[0].Value.ToString();
            DgConsulta.Rows[e.RowIndex].Cells[1].Value.ToString();
            DgConsulta.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosDTO user = new UsuariosDTO();

            var container = new UnityContainer();
            DependencyResolver.Resolve(container);


            var service = container.Resolve<IUserService>();
            user.Login = DgConsulta.SelectedCells[0].Value.ToString();
            user.Password = DgConsulta.SelectedCells[1].Value.ToString();
            DgConsulta.SelectedCells[2].ToString().ToUpper();
            user.IdUsuario = (int)DgConsulta.SelectedCells[2].Value;

            service.Delete(user);

        }
    }
    }
    

