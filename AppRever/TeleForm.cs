using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRever
{
    public partial class TeleForm : Form
    {
        public TeleForm()
        {
            InitializeComponent();
        }

        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            lblresultado.Text = "";
        }

        private void Btn_calculo_Click_1(object sender, EventArgs e)
        {
            int primeirovalor = Convert.ToInt32(txt_valor1.Text);
            int segundovalor = Convert.ToInt32(txt_valor2.Text);
            int terceirovalor = Convert.ToInt32(txt_valor3.Text);
            int maior;

            if (primeirovalor > segundovalor && primeirovalor > terceirovalor)
            {
                maior = primeirovalor;
            }
            if (segundovalor > terceirovalor)
            {
                maior = segundovalor;
            }
            else
            {
                maior = terceirovalor;
            }

            lblresultado.Text = "Primeiro valor: " + primeirovalor + "\nSegundo valor: " + segundovalor + "\nTerceiro valor: " + terceirovalor + "\n\nO maior valor é: " + maior;
        }
    }
}

