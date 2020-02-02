using System;
using System.Windows.Forms;
using Bazar.Business;


namespace Bazar.UI2
{
    public partial class FrmMenu : Form
    {
    
        UtilidadesComuns utilidades = new UtilidadesComuns();
        int X = 0;
        int Y = 0;
        public FrmMenu()
        {
            InitializeComponent();
            timer1.Enabled = true;
          
        }


        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //utilidades.OpenForm((typeof(FrmCaixa)));
          
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
           utilidades.OpenForm((typeof(FrmCadastroTelinha)));    
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            utilidades.OpenForm((typeof(FrmFerramentasTelinha)));
        }

        private void Menu_KeyUp(object sender, KeyEventArgs e)
        {
            utilidades.KeyUp(sender, e);
    
        }

        private void button5_click(object sender, EventArgs e)
        {
            utilidades.OpenForm((typeof(FrmRelatoriosTelinha2)));
         

        }

        private void BtnSobre_Click(object sender, EventArgs e)
        {
       
            utilidades.OpenForm((typeof(FrmSobre)));

        }

        private void BtnAjuda_Click(object sender, EventArgs e)
        {
            
            utilidades.OpenForm((typeof(FrmRelatoriosTelinha)));
            
        }

        private void BtnSite_Click(object sender, EventArgs e)
        {
         
        System.Diagnostics.Process.Start(@"http://www.microsoft.com.br");
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;

            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dddd  dd 'de' MMMM 'de' yyyy  \nhh:mm:ss");
        }
        
        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            utilidades.OpenForm((typeof(FrmConsultaTelinha)));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult Resp;

            Resp = MessageBox.Show("Tem certeza de que deseja Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resp == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }
        
        private void button1_Click_2(object sender, EventArgs e)
        {

           
            DialogResult Resp;

            Resp = MessageBox.Show("Tem certeza de que deseja Deslogar?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resp == DialogResult.Yes)
            {

                this.Close();
            }

        }
    
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }
    }
}
