using System;
using System.Windows.Forms;

using Bazar.Business;
using Bazar.Domain.Contracts.Services;
using Bazar.Models;
using Bazar.StartUp;
using Unity;
//using SistemaTCC2.Correios;

namespace Bazar.UI2
{
    public partial class FrmCadastroClientes : Form
    {


        ClientesModel model = new ClientesModel();
        UtilidadesComuns utilidades = new UtilidadesComuns();

        public String IDCliente;
        public FrmCadastroClientes()
        {
            InitializeComponent();
        }

  
        private void button4_Click(object sender, EventArgs e)
        {


            this.Close();
        }

        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

            utilidades.KeyPressLetras(sender,e);
        }

        private void txtEnderecoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.KeyPressLetras(sender, e);
        }
        
        private void txtTelefoneCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.KeyPressNumeros(sender, e);
        }

        private void txtCelularCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.KeyPressNumeros(sender, e);
        }

  
        private void txtNumeroCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.KeyPressNumeros(sender, e);
        }

        private void txtEmailCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.KeyPressEmail(sender, e);
        }

        private void txtBairroCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.KeyPressLetras(sender, e);
        }

        private void txtCPFCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.KeyPressEmail(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
          //  AtendeClienteClient cliente = new AtendeClienteClient();

            //Correios.enderecoERP Endereco = cliente.consultaCEP(mskCEP.Text);
            //txtEnderecoCliente.Text = Endereco.end;
            //txtBairroCliente.Text = Endereco.bairro;
            //txtMuniciopioCliente.Text = Endereco.cidade;
           // txtEstado.Text = Endereco.uf;
        }
        
        private void txtNomeCliente_Leave(object sender, EventArgs e)
        {
            utilidades.RegisterFocusEvents(Controls);

            }
        
        private void txtTelefoneCliente_Leave(object sender, EventArgs e)
        {
            utilidades.RegisterFocusEvents(Controls);    
        }

        private void txtCelularCliente_Leave(object sender, EventArgs e)
        {
            utilidades.RegisterFocusEvents(Controls);
        }

        private void txtEmailCliente_Leave(object sender, EventArgs e)
        {
            utilidades.RegisterFocusEvents(Controls);
        }

        private void txtCPFCliente_Leave(object sender, EventArgs e)
        {
            utilidades.RegisterFocusEvents(Controls);

        }
        
        private void mskCEP_Leave(object sender, EventArgs e)
        {
            utilidades.RegisterFocusEvents(Controls);
        }
        
        private void txtEnderecoCliente_Leave(object sender, EventArgs e)
        {
            utilidades.RegisterFocusEvents(Controls);
        }
        
        private void txtNumeroCliente_Leave(object sender, EventArgs e)
        {
            utilidades.RegisterFocusEvents(Controls);
        }
        
        private void txtMuniciopioCliente_Leave(object sender, EventArgs e)
        {
            utilidades.RegisterFocusEvents(Controls);
        }

        private void txtBairroCliente_Leave(object sender, EventArgs e)
        {
            utilidades.RegisterFocusEvents(Controls);
        }

        private void txtComplemento_Leave(object sender, EventArgs e)
        {
            utilidades.RegisterFocusEvents(Controls);
        }
        
        
        private void btnCadastrar(object sender, EventArgs e)
        {
            var container = new UnityContainer();
            DependencyResolver.Resolve(container);

            var service = container.Resolve<IClientesService>();
            model.NomeCliente = txtNomeCliente.Text;
            model.BairroCliente = txtBairroCliente.Text;
            model.CelularCliente = txtCelularCliente.Text;
            model.CPFCliente = txtCPFCliente.Text;
            model.EmailCliente = txtEmailCliente.Text;
            model.EnderecoCliente = txtEnderecoCliente.Text;
            model.NumeroCliente = txtNumeroCliente.Text;
            model.TelefoneCliente = txtTelefoneCliente.Text;
            


            try
            {
                service.Register(model);
                MessageBox.Show("Cliente cadastrado com sucesso!!", "Inserido com sucesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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