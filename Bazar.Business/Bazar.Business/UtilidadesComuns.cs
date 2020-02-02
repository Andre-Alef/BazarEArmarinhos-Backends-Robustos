using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bazar.Business
{
    public class UtilidadesComuns
    {
      
        public void Abrir()
        {
            OpenForm(typeof(Form));
        }


        public void OpenForm(Type frmType)
        {
            bool bolCtl = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().Equals(frmType))
                {

                    form.BringToFront();
                    bolCtl = true;
                    break;
                }
            }

            if (!bolCtl)
            {
                Form frm = (Form)Activator.CreateInstance(frmType);
                frm.Show();
            }
        }

       
            public void RegisterFocusEvents(Control.ControlCollection controls)
            {

            foreach (Control control in controls)
            {
                if ((control is TextBox) ||
                  (control is RichTextBox) ||
                  (control is ComboBox) ||
                  (control is MaskedTextBox) ||
                  (control is DataGridView)
                  )

                {
                    
                    control.Enter += new EventHandler(controlFocus_Enter);
                    control.Leave += new EventHandler(controlFocus_Leave);
                    
                }
                
                    RegisterFocusEvents(control.Controls);
                }
            }

            void controlFocus_Leave(object sender, EventArgs e)
            {
                (sender as Control).BackColor = Color.White;
            

        }

            void controlFocus_Enter(object sender, EventArgs e)
            {
                (sender as Control).BackColor = Color.LightGreen;
            }

      public void KeyPressNumeros(object sender, KeyPressEventArgs e)
        {
            

            if (!char.IsNumber(e.KeyChar) && (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void KeyPressLetras(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void KeyPressEmail(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo não aceita espaços!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void KeyUp(object sender, KeyEventArgs e)
        {
            /* if (e.KeyCode == Keys.D1)
             {
                 button1_Click(sender, e);
             }

             if (e.KeyCode == Keys.D2)
             {
                 button2_Click(sender, e);

             }


             if (e.KeyCode == Keys.D3)
             {
                 BtnConsultas_Click(sender, e);

             }

             if (e.KeyCode == Keys.D4)
             {
                 button4_Click(sender, e);

             }


             if (e.KeyCode == Keys.D5)
             {
                 button5_click(sender, e);

             }

             if (e.KeyCode == Keys.D6)
             {
                 BtnSobre_Click(sender, e);

             }


             if (e.KeyCode == Keys.D7)
             {
                 BtnAjuda_Click(sender, e);

             }


             if (e.KeyCode == Keys.D8)
             {
                 BtnSite_Click(sender, e);

             }

             if (e.KeyCode == Keys.Escape)
             {
                 label2_Click(sender, e);

             }
     */
        }

        public void Exportar(DataGridView datagrid)
        {

            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
            if (datagrid.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < datagrid.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = datagrid.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < datagrid.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < datagrid.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = datagrid.Rows[i].Cells[j].Value.ToString();
                        }

                    }
                    //

                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }

        }
    }
}
        

