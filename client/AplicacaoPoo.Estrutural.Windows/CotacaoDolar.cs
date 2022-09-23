using AplicacaoPoo.Dominio.Helpers;
using AplicacaoPoo.Dominio.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class frmConversorMoeda : Form
    {
        public frmConversorMoeda()
        {
            InitializeComponent();
            lblPrimeiroValor.Text = $"1 {MoedaHelper.Dólar} igual a";
            lblSegundoValor.Text = $"5,12  {MoedaHelper.Real}";
        }

        


        private void txtValorEmDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtValorEmDolar.Text == "") return;

               
                    var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);

                    var moeda = new ConverterMoedaService();
                    var resultado = moeda.ConverterDolarEmReal(valorEmDolar);
                    lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Dólar} igual a";
                    lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";
                
            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do valor é um valor decimal");
                txtValorEmDolar.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal CotacaoDolar = 5.12m;
            decimal CotacaoLibra = 6.15m;
            decimal CotacaoEuro = 6.0m;
        }
    }
}