using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace convertidor_temperatura
{
    public partial class Form2 : Form
    {
        //Agregamos un objeto text box
        private TextBox objTextBox = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAcep_Click(object sender, EventArgs e)
        {

        }
        private void Conversion()
        {
            try
            {
                double grados;
                //si se describe en la caja de textos grados centigrados...
                if (objTextBox == txtCen)
                {
                    grados = Convert.ToDouble(txtCen.Text);
                    txtfah.Text = ((grados * 9 / 5) + 32).ToString();
                }
                if (objTextBox == txtfah)
                {
                    grados = Convert.ToDouble(txtfah.Text);
                    txtfah.Text = ((grados * 5 / 9) - 32.0).ToString();
                }
            }
            catch (FormatException)
            {
                txtCen.Text = "0.00";
                txtfah.Text = "32.00";
            }
        }

        private void txtCen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCen_KeyPress(object sender, KeyPressEventArgs e)
        {
            objTextBox = (TextBox)sender;
            if (e.KeyChar == Convert.ToChar(13))
            {
                //enter
                e.Handled = true;
                Conversion();
            }
        }

        private void txtfah_KeyPress(object sender, KeyPressEventArgs e)
        {
            objTextBox = (TextBox)sender;
            if (e.KeyChar == Convert.ToChar(13))
            {
                //enter
                e.Handled = true;
                Conversion();
            }
        }
    }
}
