using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

using Bazar.Business;
using Bazar.Models;
using Unity;
using Bazar.StartUp;
using Bazar.Domain.Contracts.Services;

namespace Bazar.UI2
{
    public partial class FrmConsultaCliente : Form
    {
        public FrmConsultaCliente()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ClientesModel model = new ClientesModel();

            var container = new UnityContainer();
            DependencyResolver.Resolve(container);

            var service = container.Resolve<IClientesService>();
            model.NomeCliente = TxtDesc.Text;

            try
            {
                var lista = service.GetByNome(model);
            
                DgConsulta.DataSource = service.GetByNome(model);
             

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ClientesDTO cliente = new ClientesDTO();

            var container = new UnityContainer();
            DependencyResolver.Resolve(container);


            var service = container.Resolve<IClientesService>();
            cliente.NomeCliente = DgConsulta.SelectedCells[0].Value.ToString();
            cliente.TelefoneCliente = DgConsulta.SelectedCells[1].Value.ToString();
            cliente.CelularCliente = DgConsulta.SelectedCells[2].Value.ToString();
            cliente.EmailCliente = DgConsulta.SelectedCells[3].Value.ToString();
            cliente.EnderecoCliente = DgConsulta.SelectedCells[4].Value.ToString();
            cliente.BairroCliente = DgConsulta.SelectedCells[5].Value.ToString();
            cliente.NumeroCliente = DgConsulta.SelectedCells[6].Value.ToString();
            cliente.CPFCliente = DgConsulta.SelectedCells[7].Value.ToString();
            cliente.IdCliente = (int)DgConsulta.SelectedCells[8].Value;

            service.ChangeInformation(cliente);

        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesDTO cliente = new ClientesDTO();

            var container = new UnityContainer();
            DependencyResolver.Resolve(container);


            var service = container.Resolve<IClientesService>();
            cliente.NomeCliente = DgConsulta.SelectedCells[0].Value.ToString();
            cliente.TelefoneCliente = DgConsulta.SelectedCells[1].Value.ToString();
            cliente.CelularCliente = DgConsulta.SelectedCells[2].Value.ToString();
            cliente.EmailCliente = DgConsulta.SelectedCells[3].Value.ToString();
            cliente.EnderecoCliente = DgConsulta.SelectedCells[4].Value.ToString();
            cliente.BairroCliente = DgConsulta.SelectedCells[5].Value.ToString();
            cliente.NumeroCliente = DgConsulta.SelectedCells[6].Value.ToString();
            cliente.CPFCliente = DgConsulta.SelectedCells[7].Value.ToString();
            cliente.IdCliente = (int)DgConsulta.SelectedCells[8].Value;

            service.Delete(cliente);
        }
    }
}
