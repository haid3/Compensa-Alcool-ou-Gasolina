using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_gasolina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {


            if(txtbox_alcool.Text =="")
            {
                MessageBox.Show("Preencha o valor do alcool");
            }
            if (txtbox_gasolina.Text == "")
            {
                MessageBox.Show("Preencha o valor da gasolina");
            }

            double gasolina = double.Parse(txtbox_gasolina.Text);
            double alcool = double.Parse(txtbox_alcool.Text);

            if (alcool <= (gasolina * 0.7))
            {
                txtbox_resultado.Text="Alcool";

            }
            else
            {
                txtbox_resultado.Text = "Gasolina";
            }

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
