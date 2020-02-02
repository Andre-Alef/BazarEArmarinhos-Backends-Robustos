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
    public partial class FrmConsultaFornecedores : Form
    {

        public FrmConsultaFornecedores()
        {
            InitializeComponent();
        }

        private void btnConsultarFornecedores_Click(object sender, EventArgs e)
        {
            {
                FornecedoresModel model = new FornecedoresModel();

                var container = new UnityContainer();
                DependencyResolver.Resolve(container);

                var service = container.Resolve<IFornecedoresService>();
                model.Nomefornecedor = TxtDesc.Text;

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
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FornecedoresDTO fornecedores = new FornecedoresDTO();

            var container = new UnityContainer();
            DependencyResolver.Resolve(container);


            var service = container.Resolve<IFornecedoresService>();
            fornecedores.Nomefornecedor = DgConsulta.SelectedCells[0].Value.ToString();
           fornecedores.Cnpj = DgConsulta.SelectedCells[1].Value.ToString();
            fornecedores.Produtoentregue = DgConsulta.SelectedCells[2].Value.ToString();
            fornecedores.Telefonefornecedor = DgConsulta.SelectedCells[3].Value.ToString();
            fornecedores.Telefonefornecedor2 = DgConsulta.SelectedCells[4].Value.ToString();
            fornecedores.Precoprodutoforn = (double)DgConsulta.SelectedCells[5].Value;
            fornecedores.QuantidadeprodutoF = (int)DgConsulta.SelectedCells[6].Value;
            fornecedores.DataentregaF = DgConsulta.SelectedCells[7].Value.ToString();
            fornecedores.Emailfornecedor = DgConsulta.SelectedCells[8].Value.ToString();
            fornecedores.Representante = DgConsulta.SelectedCells[9].Value.ToString();



            fornecedores.IdFornecedor = (int)DgConsulta.SelectedCells[10].Value;

            service.ChangeInformation(fornecedores);

        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FornecedoresDTO fornecedores = new FornecedoresDTO();

            var container = new UnityContainer();
            DependencyResolver.Resolve(container);


            var service = container.Resolve<IFornecedoresService>();
            fornecedores.Nomefornecedor = DgConsulta.SelectedCells[0].Value.ToString();
            fornecedores.Cnpj = DgConsulta.SelectedCells[1].Value.ToString();
            fornecedores.Produtoentregue = DgConsulta.SelectedCells[2].Value.ToString();
            fornecedores.Telefonefornecedor = DgConsulta.SelectedCells[3].Value.ToString();
            fornecedores.Telefonefornecedor2 = DgConsulta.SelectedCells[4].Value.ToString();
            fornecedores.Precoprodutoforn = (double)DgConsulta.SelectedCells[5].Value;
            fornecedores.QuantidadeprodutoF = (int)DgConsulta.SelectedCells[6].Value;
            fornecedores.DataentregaF = DgConsulta.SelectedCells[7].Value.ToString();
            fornecedores.Emailfornecedor = DgConsulta.SelectedCells[8].Value.ToString();
            fornecedores.Representante = DgConsulta.SelectedCells[9].Value.ToString();



            fornecedores.IdFornecedor = (int)DgConsulta.SelectedCells[10].Value;

            service.Delete(fornecedores);
        }
    }
}
